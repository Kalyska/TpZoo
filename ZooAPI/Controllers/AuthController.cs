using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ZooAPI.DTO;
using ZooAPI.Helpers;
using ZooAPI.Repositories;
using ZooCore.Models;

namespace ZooAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;
        private readonly AppSettings _settings;
        private readonly string _securityKey;

        public AuthController(IRepository<User> userRepository,
            IOptions<AppSettings> appSettings)
        {
            _userRepository = userRepository;
            _settings = appSettings.Value;
            _securityKey = _settings.SecretKey!;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (await _userRepository.Get(u => u.Email == user.Email) != null)
                return BadRequest("Email is already taken!");

            user.Password = EncryptPassword(user.Password);
            // pour restreindre la création d'admins : isAdmin = false

            if (await _userRepository.Add(user) > 0)
                return Ok("User regitered.");
            return BadRequest("Something went wrong...");
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO login)
        {
            login.Password = EncryptPassword(login.Password);

            var user = await _userRepository.Get(u => u.Email == login.Email && u.Password == login.Password);

            if (user == null) return BadRequest("Invalid Authentication !");


            //JWT
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };

            SigningCredentials signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_settings.SecretKey!)),
                SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: _settings.ValidIssuer,
                audience: _settings.ValidAudience,
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.Now.AddDays(7)
                );

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(new
            {
                Token = token,
                Message = "Valid Authentication !",
                User = user
            });
        }

        // possible d'ajouter les actions de crud des users ici ou dans un controlleur UserController

        [NonAction]
        private string EncryptPassword(string? password)
        // il serait plus adapté de mettre ce genre de méthode dans un service dédié au chiffrage
        {
            if (string.IsNullOrEmpty(password)) return "";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + _securityKey));
        }
    }
}

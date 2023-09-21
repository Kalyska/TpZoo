using Microsoft.AspNetCore.Mvc;
using ZooAPI.Repositories;
using ZooCore.Models;

namespace ZooAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IRepository<Animal> _animalRepository;

        public AnimalController(IRepository<Animal> animalRepository)
        {
            _animalRepository = animalRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _animalRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var animal = await _animalRepository.GetById(id);
            if (animal != null)
                return Ok(animal);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddAnimal([FromBody] Animal animal)
        {
            var animalId = await _animalRepository.Add(animal);

            if (animalId > 0)
                return CreatedAtAction(nameof(Index), "Animal ajouté avec succès.");

            return BadRequest("Erreur");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAnimal([FromBody] Animal animal)
        {
            if (await _animalRepository.Update(animal))
                return Ok("Animal modifié avec succès.");

            return BadRequest("Erreur");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            if (await _animalRepository.Delete(id))
                return Ok("Animal supprimé avec succès.");

            return BadRequest("Erreur");
        }
    }
}

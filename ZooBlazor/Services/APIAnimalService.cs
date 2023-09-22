using System.Net.Http.Json;
using ZooCore.Datas;
using ZooCore.Models;

namespace ZooBlazor.Services
{
    public class APIAnimalService : IAnimalService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiRoute; // = "https://localhost:5026/api/animals";

        public APIAnimalService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseApiRoute = configuration["AnimalAPIUrlHttp"] + "api/animals";
        }


        public async Task<bool> Delete(int id)
        {
            var result = await _httpClient.DeleteAsync(_baseApiRoute + $"/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<Animal?> Get(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Animal>(_baseApiRoute + $"/{id}");
            return result;
        }

        public async Task<List<Animal>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Animal>>(_baseApiRoute);
            return result!;
        }

        public async Task<bool> Post(Animal pizza)
        {
            var result = await _httpClient.PostAsJsonAsync(_baseApiRoute, pizza);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> Put(Animal pizza)
        {
            var result = await _httpClient.PutAsJsonAsync(_baseApiRoute + $"/{pizza.Id}", pizza);
            return result.IsSuccessStatusCode;
        }
    }
}

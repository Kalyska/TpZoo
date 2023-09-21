
using ZooCore.Datas;
using ZooCore.Models;

namespace ZooBlazor.Services
{
    public class FakeDBAnimalService : IAnimalService
    {
        private List<Animal> _animals = InitialAnimal.Animals;
        private int _lastId = 0;


        //  C
        public async Task<bool> Post(Animal animal)
        {
            animal.Id = _lastId++;
            _animals.Add(animal);
            return true;
        }

        //  R
        public async Task<Animal?> Get(int id)
        {
            return _animals.FirstOrDefault(a => a.Id == id);
        }

        public async Task<List<Animal>> GetAll()
        {
            return _animals;
        }

        //  U
        public async Task<bool> Put(Animal animal)
        {
            var animalFromDb = _animals.FirstOrDefault(a => a.Id == animal.Id);
            if (animalFromDb == null)
                return false;
            animalFromDb = animal;
            return true;
        }

        //  D
        public async Task<bool> Delete(int id)
        {
            var success = _animals.RemoveAll(a => a.Id == id);
            return success == 1;
        }


    }
}

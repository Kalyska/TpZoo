using System.Linq.Expressions;
using ZooCore.Models;
using ZooAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ZooAPI.Repositories
{
    public class AnimalRepository : IRepository<Animal>
    {
        private readonly AppDbContext _context;

        public AnimalRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Animal animal)
        {
            var addedObj = await _context.Animals.AddAsync(animal);
            await _context.SaveChangesAsync();
            return addedObj.Entity.Id;
        }

        public async Task<bool> Delete(int id)
        {
            var animal = await GetById(id);
            if (animal == null)
                return false;
            _context.Animals.Remove(animal);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Animal?> Get(Expression<Func<Animal, bool>> predicate)
        {
            return await _context.Animals.Include(a => a.Species).FirstOrDefaultAsync(predicate);
        }

        public async Task<List<Animal>> GetAll()
        {
            return await _context.Animals.Include(a => a.Species).ToListAsync();
        }

        public async Task<List<Animal>> GetAll(Expression<Func<Animal, bool>> predicate)
        {
            return await _context.Animals.Where(predicate).Include(a => a.Species).ToListAsync();
        }

        public async Task<Animal?> GetById(int id)
        {
            return await _context.Animals.Include(a => a.Species).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<bool> Update(Animal animal)
        {
            var animalFromDb = await GetById(animal.Id);

            if (animalFromDb == null)
                return false;

            if (animal.SpeciesId != animalFromDb.SpeciesId)
                animalFromDb.SpeciesId = animal.SpeciesId;
            if(animal.Name != animalFromDb.Name)
                animalFromDb.Name = animal.Name;
            if(animal.Age != animalFromDb.Age)
                animalFromDb.Age = animal.Age;
            if(animal.Description != animalFromDb.Description)
                animalFromDb.Description = animal.Description;
            if(animal.ImageUrl != animalFromDb.ImageUrl)
                animalFromDb.ImageUrl = animal.ImageUrl;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}

using Microsoft.AspNetCore.Components;
using ZooBlazor.DTOs;
using ZooBlazor.Services;
using ZooCore.Models;

namespace ZooBlazor.Pages
{
    public partial class Index
    {

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public IAnimalService AnimalService { get; set; }

        private bool IsZooMember { get; set; } = false;

        private List<Animal> Animals { get; set; } = new List<Animal>();

        private AnimalEditDTO? AnimalToEdit { get; set; } = null;

        private EditionModes EditionMode { get; set; }

        private enum EditionModes
        {
            Post,
            Put
        }

        protected override async Task OnInitializedAsync()
        {
            Animals = await AnimalService.GetAll();
        }

        private void AddAnimal()
        {
            AnimalToEdit = new AnimalEditDTO();
            EditionMode = EditionModes.Post;
        }

        private void EditAnimal(Animal animal)
        {
            AnimalToEdit = new AnimalEditDTO()
            {
                Id = animal.Id,
                Name = animal.Name,
                Description = animal.Description,
                ImageUrl = animal.ImageUrl,
                Age = animal.Age,
                SpeciesId = animal.SpeciesId,
            };
            EditionMode = EditionModes.Put;
        }

        private async Task DeletePizza(int id)
        {
            Animals.RemoveAll(animal => animal.Id == id);
            await AnimalService.Delete(id);
        }

        private async Task SubmitAnimal()
        {
            switch (EditionMode)
            {
                case EditionModes.Post:
                    var animal1 = new Animal()
                    {
                        Name = AnimalToEdit!.Name,
                        Description = AnimalToEdit!.Description,
                        ImageUrl = AnimalToEdit!.ImageUrl,
                        Age = AnimalToEdit!.Age,
                        SpeciesId = AnimalToEdit!.SpeciesId,
                    };
                    Animals.Add(animal1);
                    await AnimalService.Post(animal1);
                    break;

                case EditionModes.Put:
                    var animal2 = Animals.Find(animal2 => animal2.Id == AnimalToEdit!.Id)!;
                    animal2.Name = AnimalToEdit!.Name;
                    animal2.Description = AnimalToEdit!.Description;
                    animal2.ImageUrl = AnimalToEdit!.ImageUrl;
                    animal2.Age = AnimalToEdit!.Age;
                    animal2.SpeciesId = AnimalToEdit!.SpeciesId;

                    await AnimalService.Put(animal2);
                    break;

                default:
                    break;
            }

            AnimalToEdit = null;
        }
    }
}

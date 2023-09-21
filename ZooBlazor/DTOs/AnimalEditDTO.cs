using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZooCore.Models;

namespace ZooBlazor.DTOs
{
    public class AnimalEditDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le Nom est requis.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "L'espèce est requise.")]
        public int SpeciesId { get; set; }

        [Required(ErrorMessage = "La description est requise.")]
        public string? Description { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "L'age doit être compris entre 1 et 99 €.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Le lien vers l'image est requis.")]
        public string? ImageUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCore.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey(nameof(Species))]
        public int SpeciesId { get; set; }
        public Species? Species { get; set; }
        public string? Description { get; set; }
        public int Age { get; set; }
        public string? ImageUrl { get; set; }
    }
}

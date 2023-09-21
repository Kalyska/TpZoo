using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCore.Models
{
    public class Species
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public ConservationStatus Status { get; set; }
        public List<Animal>? Animals { get; set; }
    }

    public enum ConservationStatus
    {
        Unknown,
        LeastConcern,
        NearThreatened,
        Vulnerable,
        Endangered,
        CriticallyEndangered,
        ExtinctInTheWild,
        Extinct
    }
}

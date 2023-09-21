using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCore
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Species? Species { get; set; }
        public string? Description { get; set; }
        public int Age { get; set; }
        public string? ImageUrl { get; set; }
        public ConservationStatus Status { get; set; }
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

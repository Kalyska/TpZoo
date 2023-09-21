using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCore
{
    public class Species
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public IEnumerable<Animal>? Animals { get; set; }
    }
}

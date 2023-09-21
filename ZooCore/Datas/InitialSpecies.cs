using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooCore.Models;

namespace ZooCore.Datas
{
    public static class InitialSpecies
    {
        public static readonly List<Species> zooSpecies = new List<Species>()
        {
            new Species() { Id = 1, Name="Alligator", Status=ConservationStatus.LeastConcern },
            new Species() { Id = 2, Name="Calao", Status=ConservationStatus.Vulnerable },
            new Species() { Id = 3, Name="Chimpanzé", Status=ConservationStatus.Endangered },
            new Species() { Id = 4, Name="Chauve-souris", Status=ConservationStatus.Endangered },
            new Species() { Id = 5, Name="Eléphant d'Afrique", Status=ConservationStatus.Endangered },
            new Species() { Id = 6, Name="Girafe", Status=ConservationStatus.Endangered },
            new Species() { Id = 7, Name="Gorille", Status=ConservationStatus.CriticallyEndangered },
            new Species() { Id = 8, Name="Guépard", Status=ConservationStatus.Vulnerable },
            new Species() { Id = 9, Name="Hippopotame", Status=ConservationStatus.Vulnerable },
            new Species() { Id = 10, Name="Lion", Status=ConservationStatus.Vulnerable },
            new Species() { Id = 13, Name="Panda", Status=ConservationStatus.Vulnerable },
            new Species() { Id = 14, Name="Dragon de Komodo", Status=ConservationStatus.Endangered },
            new Species() { Id = 15, Name="Diable de Tasmanie", Status=ConservationStatus.Endangered }
        };
    }
}

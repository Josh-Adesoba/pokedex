using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Sprites Sprites { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}

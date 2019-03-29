using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokedex.Models;

namespace Pokedex.ViewModels
{
    public class PokemonViewModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string ImageFront { get; set; }
        public string ImageBack { get; set; }
        public string ImageFemale { get; set; }
        public string ImageFemaleBack { get; set; }
        public string ImageFrontShiny { get; set; }
        public string ImageBackShiny { get; set; }
        public string ImageFemaleShiny { get; set; }
        public string ImageFemaleBackShiny { get; set; }
//        public string Image { get; set; }
        public string Color { get; set; }
        public List<FlavorText> FlavorText { get; set; }
        public List<PokemonType> Types { get; set; }

    }
}

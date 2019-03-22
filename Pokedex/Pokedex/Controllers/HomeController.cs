using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Pokedex.ViewModels;

namespace Pokedex.Controllers
{
    public class HomeController : Controller
    {
        [Route("pokemon/{name}")]
        public async Task<IActionResult> Index(string name)
        {
            var pokemon = await "https://pokeapi.co/api/v2/pokemon/".AppendPathSegment(name).GetJsonAsync<Pokemon>();
//            var color = await "https://pokeapi.co/api/v2/pokemon-color/".AppendPathSegment(pokemon.Id).GetJsonAsync<Color>();
            var viewModel = new PokemonViewModel
            {
                Name = pokemon.Name,
//                Color = color.Name,
                ImageFront = pokemon.Sprites.Front_Default,
                ImageFemale = pokemon.Sprites.Front_Female,
                ImageBack = pokemon.Sprites.Back_Default,
                ImageFemaleBack = pokemon.Sprites.Back_Female,
                ImageFrontShiny = pokemon.Sprites.Front_Shiny,
                ImageBackShiny = pokemon.Sprites.Back_Shiny,
                ImageFemaleShiny = pokemon.Sprites.Front_Shiny_Female,
                ImageFemaleBackShiny = pokemon.Sprites.Back_Shiny_Female,
                Number = pokemon.Id,
                Height = pokemon.Height,
                Weight = pokemon.Weight
            };
            return View(viewModel);
        }

    }
}

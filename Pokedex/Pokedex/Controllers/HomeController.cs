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
            var color = await "https://pokeapi.co/api/v2/pokemon-color/".AppendPathSegment(pokemon.Id).GetJsonAsync<Color>();
            var viewModel = new PokemonViewModel
            {
                Name = pokemon.Name,
                Color = color.Name,
                Image = pokemon.Sprites.Front_Default,
                Number = pokemon.Id
            };
            return View(viewModel);
        }

    }
}

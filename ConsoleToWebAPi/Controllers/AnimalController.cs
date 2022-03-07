using ConsoleToWebAPi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalController()
        {
            animals = new List<AnimalModel>() {
                new AnimalModel(){Id = 10, Name = "Dog"},
                new AnimalModel(){Id = 11, Name = "Cat"},
            };

        }

        [Route("")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }


        [Route("test")]
        public IActionResult GetAnimals2()
        {
            return AcceptedAtAction("GetAnimals"); //
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name) {
            if (!name.Contains("ABC")) {
                return BadRequest( );
            }

            return Ok(animals);
        }
    }
}

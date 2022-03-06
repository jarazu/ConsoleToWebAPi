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
        [Route("")]
        public IActionResult GetAnimals()
        {
            var animals = new List<AnimalModel>() { 
                new AnimalModel(){Id = 10, Name = "Dog"},
                new AnimalModel(){Id = 11, Name = "Cat"},
            };
            return Ok(animals);
        }


        [Route("test")]
        public IActionResult GetAnimals2()
        {
            var animals = new List<AnimalModel>() {
                new AnimalModel(){Id = 10, Name = "Dog"},
                new AnimalModel(){Id = 11, Name = "Cat"},
            };
            return AcceptedAtAction("GetAnimals");
        }
    }
}

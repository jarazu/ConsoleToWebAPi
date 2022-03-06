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
    public class EmployeeController : ControllerBase
    {
        public List<EmployeeModel> GetEmloyees()
        {
            return new List<EmployeeModel>() {
               new EmployeeModel(){Id=1, Name = "Razu"},
               new EmployeeModel(){Id=2, Name = "Alam"}
            };
        }

        //[Route("{id}")]
        //public IActionResult GetEmloyees2(int id)
        //{
        //    if (id == 0) {
        //        return NotFound();
        //    }
        //   return Ok(new List<EmployeeModel>() {
        //       new EmployeeModel(){Id=1, Name = "Razu"},
        //       new EmployeeModel(){Id=2, Name = "Alam"}
        //    });
        //}

        [Route("{id}")]
        public ActionResult<EmployeeModel> GetEmloyees2(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 1, Name = "Razu" };
        }
    }
}

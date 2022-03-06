using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("get-all")]
        public string GetAll() {
            return "Hello get all";
        }

        [Route("get-all-authors")]
        public string GetAllAuthors() {
            return "Hello from get all authors"; 
        }

        [Route("books/{id}/author/{authorid}")]
        public string GetAuthorBYID(int id, int authorid) { 
            return "Hello "+id+" "+authorid;
        }

        [Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price) {
            return "";
        }
    }
}

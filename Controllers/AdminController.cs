using BackEndKino.Entitys;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Controllers
{
    [ApiController]
    public class AdminController : Controller
    {
        
        [HttpGet("Page/Main")]
        [Route("Page/main")]
        public IActionResult Index()
        {
            Movie M = new Movie();
            M.Name = "Test";
            M.Tags.Add(new Tag { Name = "dsggsf" });
            M.Tags.Add(new Tag { Name = "fdsfsdf" });

            return Json(M);
        }
    }
}

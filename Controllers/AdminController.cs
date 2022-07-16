using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Controllers
{
    public class AdminController : Controller
    {
        [Route("Pages/Main")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

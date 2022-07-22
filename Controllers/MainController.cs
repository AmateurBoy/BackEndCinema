using BackEndKino.DB;
using BackEndKino.DB.DAO;
using BackEndKino.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace BackEndKino.Controllers
{
    
    [ApiController]
    public class MainController : Controller
    {
        public IDAO<Movie> DTO = new MoviesDAO();
        public ApplicationContext AC = new();
        
        [HttpGet("/main/movies")]
        public IActionResult Index()
        {
            return Json(DTO.GetAll());
        }
        [HttpGet("/")]
        [HttpGet("/main")]
        public IActionResult Redirect()
        {
            return Redirect("/index.html");
        }
        [HttpPost("admin/movies")]
        public IActionResult AddMovies(Movie M)
        {
            DTO.Add(M);
            return View(M.Id);
        }

    }
}

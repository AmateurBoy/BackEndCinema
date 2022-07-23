using BackEndKino.DB;
using BackEndKino.DB.DAO;
using BackEndKino.Entitys;
using BackEndKino.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BackEndKino.Controllers
{
    
    [ApiController]
    public class MainController : Controller
    {
        public IDAO<Movie> DTO = new MoviesDAO();
       
        public DownloadService DS = new();

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
        public async Task<IActionResult> Upload(IFormCollection IFF)
        
        {

            Movie movie = new Movie
            {
                Name = IFF["name"],
                Disc = IFF["description"],
                URLtrailer = IFF["trailerURL"],
                mainImageName = IFF.Files[0].FileName,
            };
            DS.Upload(IFF);
            DTO.Add(movie);
            

            return Ok();
        }

    }
}

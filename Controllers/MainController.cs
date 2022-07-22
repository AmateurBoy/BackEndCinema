using BackEndKino.DB;
using BackEndKino.DB.DAO;
using BackEndKino.Entitys;
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
       
        public async Task<IActionResult> Upload(IFormCollection IFF)
        {
            var file = IFF.Files[0];

            string filePut = @$"D:\C#\BackEndKino\wwwroot\resources\images\{file.FileName}"; 

            using (var stream = System.IO.File.Create(filePut))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(file);
        }

    }
}

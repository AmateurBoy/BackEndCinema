using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndKino.Entitys;

namespace BackEndKino
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            
            using (DB.AppContext DB = new DB.AppContext())
            {
                Tag tag = new Tag
                {
                    Name = "Комедия"
                };
                Tag tag1 = new Tag
                {
                    Name = "Драма"
                };
                Tag tag2 = new Tag
                {
                    Name = "Боевик"
                };
                Tag tag3 = new Tag
                {
                    Name = "Аниме"
                };
                DB.Tags.AddRange(tag, tag1, tag2, tag3);
                DB.SaveChanges();
                

                Movie m = new Movie
                {
                    Name="Халк",
                    Tags= new List<Tag> { tag,tag2,tag3 }
                };
                Movie m1 = new Movie
                {
                    Name = "Твое имя",
                    Tags = new List<Tag> { tag1 }
                };

                DB.Movies.AddRange(m,m1);
                DB.SaveChanges();
            }
            CreateHostBuilder(args).Build().Run();
            

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

using BackEndKino.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace BackEndKino.DB.DAO
{
    public class MoviesDAO : IDAO<Movie>
    {
        public Movie Add(Movie acc)
        {
            using (ApplicationContext AC = new())
            {
                Movie Movies = acc;

                if (AC.Movies.FirstOrDefault(x => x.Id == Movies.Id) == null)
                {
                    AC.Movies.Add(Movies);
                    AC.SaveChanges();
                    return Movies;
                }
                else
                {
                    throw new System.ArgumentException("Фильм уже существует", nameof(Movies));
                }

            }

        }
        public bool Delate(int id)
        {
            using (ApplicationContext AC = new())
            {
                try
                {
                    AC.Movies.Remove(AC.Movies.FirstOrDefault(x => x.Id == id));
                    AC.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
        public List<Movie> GetAll()
        {
            using (ApplicationContext AC = new())
            {
                var Movies = AC.Movies.ToList();
                return Movies;
            }
        }
        public Movie GetbyID(int Id)
        {
            using (ApplicationContext AC = new())
            {
                var Movies = AC.Movies.FirstOrDefault(x => x.Id == Id);
                if (Movies != null)
                {
                    return Movies;
                }
                else
                {
                    throw new System.ArgumentException("Фильм не найден", nameof(Movies));
                }


            }
        }
    }
}

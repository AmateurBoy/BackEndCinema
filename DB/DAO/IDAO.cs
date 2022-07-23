using BackEndKino.Entitys;
using System.Collections.Generic;

namespace BackEndKino.DB.DAO
{
    public interface IDAO<T> where T : ITablekay
    {
        public T Add(T t);
        public T GetbyID(int Id);
        public List<T> GetAll();
        public bool Delate(int id);
        
    }
}

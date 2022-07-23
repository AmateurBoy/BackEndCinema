using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Entitys
{
    public class Movie : ITablekay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Disc { get; set; }
        public string mainImageName { get; set; }
        public string URLtrailer { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }        
        
    }
}

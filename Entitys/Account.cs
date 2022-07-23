using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Entitys
{
    public class Account:ITablekay
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Billing> Billings { get; set; }

       
    }
}

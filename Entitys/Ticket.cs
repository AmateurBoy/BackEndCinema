using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Entitys
{
    public class Ticket
    {
        public int Id { get; set; }
        public virtual Session Session { get; set; }
        public virtual Billing Billing { get; set; }
    }
}

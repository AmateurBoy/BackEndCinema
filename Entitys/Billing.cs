using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Entitys
{
    public class Billing
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool Paid { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DatePaid { get; set; }
    }
}

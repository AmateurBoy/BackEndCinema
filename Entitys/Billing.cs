using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Entitys
{
    public class Billing:ITablekay
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public bool Paid { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DatePaid { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.Entitys
{
    public class Session : ITablekay
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        
    }
}

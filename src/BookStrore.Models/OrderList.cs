﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class OrderList
    {

        public virtual long IdUser { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual DateTime OrderDate { get; set; }
    }
}
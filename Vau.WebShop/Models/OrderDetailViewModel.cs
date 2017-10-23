﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vau.WebShop.Models
{
    public class OrderDetailViewModel
    {
        public int OrderID { set; get; }

        public int ProductID { set; get; }

        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public virtual OrderViewModel Order { set; get; }

        public virtual ProductViewModel Product { set; get; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vau.WebShop.Models
{
    public class ProductTagViewModel
    {
        public int ProductID { set; get; }

        public String TagID { set; get; }

        public virtual ProductViewModel Product { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}
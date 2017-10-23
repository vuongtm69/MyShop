﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vau.WebShop.Models
{
    public class TagViewModel
    {
        public string ID { set; get; }

        public string Name { set; get; }

        public string Type { set; get; }

        public virtual IEnumerable<ProductTagViewModel> ProductTags { set; get; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vau.WebShop.Models
{
    public class OrderViewModel
    {
        public int ID { set; get; }

        public string CustomerName { set; get; }

        public string CustomerAdress { set; get; }

        public string CustomerEmail { set; get; }

        public string CustomerMobile { set; get; }

        public string CustomerMessage { set; get; }

        public DateTime CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vau.WebShop.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        public string Alias { set; get; }

        public int? ParentID { set; get; }

        public string Image { set; get; }

        public int? DisplayOrder { set; get; }

        public bool? HomeFlag { set; get; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}
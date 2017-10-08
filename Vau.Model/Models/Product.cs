﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using Vau.Model.Abstract;

namespace Vau.Model.Models
{
    [Table("Products")]
    public class Product : AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }

        public int CategoryID { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public decimal? Waranty { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
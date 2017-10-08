﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vau.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [MaxLength((250))]
        public string Name { set; get; }

        [MaxLength((50))]
        public string Type { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
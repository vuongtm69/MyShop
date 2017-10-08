﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vau.Model.Abstract;

namespace Vau.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : AuditTable
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

        public int? ParentID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public int? DisplayOrder { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}
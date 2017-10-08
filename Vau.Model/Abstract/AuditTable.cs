using System;
using System.ComponentModel.DataAnnotations;

namespace Vau.Model.Abstract
{
    public abstract class AuditTable : IAuditTable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(50)]
        public string UpdateBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        [Required]
        public bool Status { set; get; }
    }
}
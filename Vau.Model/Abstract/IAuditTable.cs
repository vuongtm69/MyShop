using System;

namespace Vau.Model.Abstract
{
    public class IAuditTable
    {
        private DateTime CreatedDate { get; set; }
        private string CreatedBy { get; set; }
        private DateTime? UpdateDate { get; set; }
        private string UpdateBy { get; set; }
        private string MetaKeyword { set; get; }
        private string MetaDescription { set; get; }
        private bool Status { set; get; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vau.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public DateTime VisitDate { set; get; }

        [Required]
        [MaxLength(50)]
        public string IpAdress { set; get; }
    }
}
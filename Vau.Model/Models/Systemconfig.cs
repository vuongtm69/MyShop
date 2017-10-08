using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vau.Model.Models
{
    [Table("SystemConfig")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(50)]
        public string Code { set; get; }

        [MaxLength(250)]
        public string ValueString { set; get; }

        public int ValueInt { set; get; }
    }
}
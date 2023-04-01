using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.BEModels
{
    [Table("CompetencyDetails")]
    public class CompetencyDetail
    {
        [Key]
        // [Column(TypeName = "int")]
        public int CompId  { get; set; }

        [Required]
        // [Column(TypeName = "varchar(200)")]
        public string CompetencyName { get; set; }
    }
}

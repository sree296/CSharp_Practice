using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.BEModels
{
    [Table("CaseStudySolutions")]
    public class CaseStudySolution
    {
        [Key]
        // [Column(TypeName = "int")]
        public int CSSID { get; set; }

        [Required]
        // [Column(TypeName = "varchar(200)")]
        public string SolutionName { get; set; }

        public int CaseStudtID { get; set; }

        public int CompetencyID { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("LanguageDetails")]
    public class LanguageDetail
    {
        [Key]
        public int LangId { get; set; }
        public string LangName { get; set; }
        public bool Selected { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("CountryDetails")]
    public class CountryDetail
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}

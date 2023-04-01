using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("VendorInformations")]
    public class VendorInfo
    {
        [Key]
        public int VID { get; set; }
        public string VName { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}

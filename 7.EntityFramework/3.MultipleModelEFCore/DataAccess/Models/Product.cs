using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("ProductsInfo")]
    public  class Product
    {
       [Key]
       public int ProductID { get; set; }
       public string PName { get; set; }
       public decimal PPrice { get; set; }
       public int VID { get; set; }
    }
}

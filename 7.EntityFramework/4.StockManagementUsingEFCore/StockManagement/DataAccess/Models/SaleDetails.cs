using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class SaleDetails
    {
       [Key]
       public int SalesID { get; set; }

        [Required]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Id")]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

       [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Invalid Produt Name")]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Sales Date")]
        public DateTime? SalesDate { get; set; }

        [Required]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Quantity")]
        [Display(Name = "Purchase Qty")]
        public int SalesQty { get; set; }
    }
}

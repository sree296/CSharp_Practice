using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PurchaseDetails
    {
       [Key]
       public int PurchaseId { get; set; }
       
        [Required]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Id")]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

       [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Invalid Product Name")]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Purchase Date")]
        public DateTime? PurchaseDate { get; set; }

       [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Qunatity")]
        [Display(Name = "Purchase Qty")]
        public int PurchaseQty { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using DataAccess.Models;

namespace StockManagement.Models
{
    public class PurchaseInfo
    {
        public int PurchaseId { get; set; }

        [Required]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Id")]

        [Display(Name = "Product Name")]
        public int ProductId { get; set; }
        public List<Products> ProductList { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Purchase Date")]
        public DateTime? PurchaseDate { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Qunatity")]
        [Display(Name = "Purchase Qty")]
        public int PurchaseQty { get; set; }
    }
}

using DataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace StockManagement.Models
{
    public class SalesInfo
    {
        public int SalesID { get; set; }

        [Required]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Id")]

        [Display(Name = "Product Name")]
        public int ProductId { get; set; }
        public List<Products> ProductList { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Sales Date")]
        public DateTime? SalesDate { get; set; }

        [Required]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Invalid Quantity")]
        [Display(Name = "Sales Qty")]
        public int SalesQty { get; set; }
    }
}

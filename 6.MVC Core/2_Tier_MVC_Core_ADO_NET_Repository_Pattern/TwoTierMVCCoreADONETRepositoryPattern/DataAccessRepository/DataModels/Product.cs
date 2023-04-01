using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessRepository.DataModels
{
    public class Product
    {
        [DisplayName("Product Name")]
        public string PName { get; set; }

        [DisplayName("Product Price")]
        public decimal PPrice { get; set; }

        [DisplayName("Stock Qty")]
        public int StockQty { get; set; }

        [DisplayName("Vendor ID")]
        public int VID { get; set; }

    }
}

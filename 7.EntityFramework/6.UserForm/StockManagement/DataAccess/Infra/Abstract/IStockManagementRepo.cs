using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Abstract
{
    public interface IStockManagementRepo
    {
        StockDetails GetStockDetails();
    }
}

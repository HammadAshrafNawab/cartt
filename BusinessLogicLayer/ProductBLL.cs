using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class ProductBLL
    {
        ProductDAL obj = new ProductDAL();

        public DataTable GetAllProductsShoppingBLL()
        {
            return obj.GetAllProductsShoppingDAL();
        }

        public DataTable SearchProductShoppingBLL(ProductProps pp)
        {
            return obj.SearchProductShoppingDAL(pp);
        }
    }
}

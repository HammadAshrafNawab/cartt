using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DataAccessLayer
{
    public class ProductDAL
    {
        DBConn obj = new DBConn();

        public DataTable GetAllProductsShoppingDAL()
        {
            string qry = "Select * from Products";
            return obj.Search(qry);
        }

        public DataTable SearchProductShoppingDAL(ProductProps pp)
        {
            string qry = "Select * from Products where ID = '" + pp.ProductID + "'";
            return obj.Search(qry);
        }
    }
}

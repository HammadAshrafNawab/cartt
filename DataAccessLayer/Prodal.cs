using AppProps;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Prodal
    {
        DBConn db = new DBConn();

        public bool insertproduct(ProductProps p)
        {
            string qry = "insert into Products (NAME,DESCRIPTION,PRICE,Imagess) values ('" + p.ProductName + "', '" + p.ProductDescription + "','" + p.ProductPrice + "','" + p.Imageupload + "') ";
            return db.UDI(qry);
        }
    }
}

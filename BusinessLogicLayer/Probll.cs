using AppProps;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Probll
    {
        Prodal uDal = new Prodal();
        public string insertproductBll(ProductProps p)
        {
            bool insertp = uDal.insertproduct(p);
            if (insertp)
            {
                return "DATA INSERTED";
            }
            else
            {
                return "DATA NOT INSERTED";
            }
        }

    }
}

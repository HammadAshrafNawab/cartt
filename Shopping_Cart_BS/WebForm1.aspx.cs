using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using AppProps;
using DataAccessLayer;

namespace Shopping_Cart_BS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Probll bll = new Probll();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            ProductProps p = new ProductProps();

            p.ProductName = txtName.Text;
            p.ProductDescription = txtdescription.Text;
            p.ProductPrice = Int32.Parse(txtprice.Text);
          
           
            p.Imageupload = FileUpload1.FileName.ToString();

            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + p.Imageupload);
            bll.insertproductBll(p);

        }

    }
}
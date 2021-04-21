using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BusinessLogicLayer;
using System.Data;

namespace Shopping_Cart_BS
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ProductBLL obj = new ProductBLL();
                DataTable dt = obj.GetAllProductsShoppingBLL();
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }

        protected void btnAddtoCart_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "viewdetails")
            {
                int id = Int16.Parse(e.CommandArgument.ToString());
                ProductProps p = new ProductProps();
                p.ProductID = id;
                ProductBLL pb = new ProductBLL();
                DataTable dt = pb.SearchProductShoppingBLL(p);
                p.ProductName = dt.Rows[0]["Name"].ToString();
                p.ProductImage = dt.Rows[0]["Imagess"].ToString();
                p.ProductPrice = float.Parse(dt.Rows[0]["Price"].ToString());
                p.ProductDescription = dt.Rows[0]["Description"].ToString();
                Cart cart = null;
                if(Session["Cart"] != null)
                {
                    cart = (Cart)Session["Cart"];
                }
                Cart newCart = new Cart(cart);
                if(newCart.AddtoCart(p, 1))
                {
                    Session["Cart"] = newCart;
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    Response.Write(@"<script language='javascript'>alert('Items not add in the cart')");
                }
            }
        }
    }
}
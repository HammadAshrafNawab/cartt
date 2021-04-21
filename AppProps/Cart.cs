using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Cart
    {
        public List<MyProduct> items = null;
        public int totalQty = 0;
        public float totalPrice = 0;

        public Cart (Cart oldCart)
        {
            if(oldCart != null)
            {
                items = oldCart.items;
                totalQty = oldCart.totalQty;
                totalPrice = oldCart.totalPrice;
            }
        }

        public bool AddtoCart(ProductProps pp, int qty)
        {
            if(items == null)  // cart is empty
            {
                MyProduct obj = new MyProduct();
                obj.products = pp;
                obj.quantity = qty;
                obj.subtotal = pp.ProductPrice * qty;
                items = new List<MyProduct>();
                items.Add(obj);
                totalQty++;
                totalPrice = obj.subtotal;
                return true;
            }
            else // cart is not empty
            {
                MyProduct prevItem = items.FirstOrDefault(x => x.products.ProductID == pp.ProductID);
                if(prevItem != null) // item is already in the list
                {
                    totalPrice = totalPrice + (qty * prevItem.products.ProductPrice);
                    prevItem.quantity = prevItem.quantity + qty;
                    prevItem.subtotal = prevItem.subtotal + qty * prevItem.products.ProductPrice;
                    return true;
                }
                else  // item is not in the cart, new item
                {
                    MyProduct obj = new MyProduct();
                    obj.products = pp;
                    obj.quantity = qty;
                    obj.subtotal = pp.ProductPrice * qty;
                    items.Add(obj);
                    totalQty++;
                    totalPrice = totalPrice + obj.subtotal;
                    return true;
                }
            }
        }

        public bool RemovefromCart(ProductProps pp, int qty)
        {
            MyProduct prevItem = items.FirstOrDefault(x => x.products.ProductID == pp.ProductID);
            if(qty == -1)
            {
                totalQty--;
                totalPrice = totalPrice - (prevItem.quantity * prevItem.products.ProductPrice);
                items.Remove(prevItem);
                return true;
            }
            return false;
        }
    }

    public class MyProduct
    {
        public ProductProps products;
        public int quantity;
        public float subtotal;
    }
}

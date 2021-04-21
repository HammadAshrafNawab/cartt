using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class ProductProps
    {
        private int id;
        private string name;
        private string image;
        private float price;
        private string description;
        private string imageupload;

        public int ProductID
        {
            get { return id; }
            set { id = value; }
        }

        public string ProductName
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductImage
        {
            get { return image; }
            set { image = value; }
        }

        public float ProductPrice
        {
            get { return price; }
            set { price = value; }
        }

        public string ProductDescription
        {
            get { return description; }
            set { description = value; }
        }

        public string Imageupload { get => imageupload; set => imageupload = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL
{
    public class Product
    {
        public static int currentProductId;
        private string description;
        private double price;
        private string productId;
        private string productName;
    
        public string Description {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            } 
         }

        public double Price {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            } 
        }

        public string ProductId {
            get
            {
                return this.productId;
            }
            set
            {
                this.productId = value;
            }
        }

        public string ProductName {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }

        static Product()
        {
            currentProductId = 100;
        }
        public Product()
        {
            productId = ("P" + currentProductId);
            currentProductId++;
            Console.WriteLine(productId);
        }

        public Product(string productName, string description, double price)
        {
            this.productName = productName;
            this.description = description;
            this.price = price;
        }
    }
}

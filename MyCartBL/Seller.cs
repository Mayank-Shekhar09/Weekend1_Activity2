using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL
{
    public class Seller
    {

        private string sellerId;
        public static int sellerIdCount;
        private string sellerName;
        string[] sellerLocations = new string[10000];

        public string SellerId {
            get
            {
                return this.sellerId;
            }
            set
            {
                this.sellerId = value;
            } 
        }

        public string[] SellerLocations {
            get
            {
                return this.sellerLocations;
            }
            set
            {
                this.sellerLocations = value;
            }
        }

        public string SellerName {
            get
            {
                return this.sellerName;
            }
            set
            {
                this.sellerName = value;
            }
        }
        static Seller()
        {
            sellerIdCount = 1001;
        }
        public Seller()
        {
            sellerId = ("S" + sellerIdCount);
            sellerIdCount++;
            Console.WriteLine(sellerId);
        }

        public Seller(string sellerName)
        {
            this.sellerName = sellerName;
        }
    }

}

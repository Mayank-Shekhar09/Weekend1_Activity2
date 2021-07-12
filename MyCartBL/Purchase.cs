using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL
{
    public class Purchase
    {
        DateTime dateOfPurchase;
        string paymentType;
        public static int purchaseCounter;
        string purchaseId;
        int quantityOrdered;
        string shippingAddress;

        public DateTime DateOfPurchase { 
            get
            {
                return this.dateOfPurchase;
            }
            set
            {
                this.dateOfPurchase = value;
            }
        }

        public string PaymentType {
            get
            {
                return this.paymentType;
            }
            set
            {
                this.paymentType = value;
            }
        }

        public string PurchaseId {
            get
            {
                return this.purchaseId;
            }

            set
            {
                this.purchaseId = value;
            }
        }

        public int QuantityOrdered {
            get
            {
                return this.quantityOrdered;
            }
            set
            {
                this.quantityOrdered = value;
            }
        }

        public string ShippingAddress {
            get
            {
                return this.shippingAddress;
            }
            set
            {
                this.shippingAddress = value;
            }
        }

        public double CalculateBillAmount(double price)
        {
            return 0.0;
        }

        public double CalculateBillAmount(double price, double discountPercentage)
        {
            return 0.0;
        }

        public double GetPurchasePercentage(DateTime[] transactionDates, DateTime dateForReport)
        {
            int count = 0;
            foreach (DateTime transaction in transactionDates)
            {
                
                if (transaction == dateForReport)
                {
                    count++;
                }

            }
            double purchasePercentage = (count / transactionDates.Length) * 100;
            return purchasePercentage;
        }

        static Purchase()
        {
            purchaseCounter = 1001;
        }
        public Purchase()
        {
            purchaseId = ("B" + purchaseCounter);
            purchaseCounter++;
            Console.WriteLine(purchaseId);
        }

        public Purchase(int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
        {

        }

        public double RoundOffBill(double amount)
        {
            return (Math.Round(amount, 2));
        }
    }
}

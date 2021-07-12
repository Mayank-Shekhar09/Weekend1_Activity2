using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL
{
    public class Customer
    {

        public class Enums
        {
            public enum Genders
            {
                male,
                female,
                others
            }
        }

        private String address;
        static int currentValueForCustomerId;
        private int customerId;
        private string customerName;
        private string customerType;
        private DateTime dateOfBirth;
        private string emailId;
        private Enums.Genders gender;
        private string password;

        public string Address {
            get
            {
                return this.address;
            }
            set {
                this.address = value;
            }

        }
        public int CustomerId {
            get
            {
                return this.customerId;
            }
            set
            {
                this.customerId = value;
            }
        }

        public string CustomerName {
            get
            {
                return this.customerName;
            }
            set
            {
                this.customerName = value;
            }
        }

        public string CustomerType {
            get
            {
                return this.customerType;
            }
            set
            {
                this.customerType = value;
            }
        }

        public DateTime DateOfBirth {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }

        public string EmailId {
            get
            {
                return this.emailId;
            }
            set
            {
                this.emailId = value;
            }
        }

        public Enums.Genders Gender {
            get {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public string Password {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            } 
        }
        static Customer()
        {
            currentValueForCustomerId = 1000;
        }

        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId++;
        }

        public Customer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Genders gender, string password, string customerType)
        {
            this.customerName = customerName;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.emailId = emailId;
            this.gender = gender;
            this.password = password;
            this.customerType = customerType;
        }

        public double GetDiscount()
        {
            Console.WriteLine("Enter Discount Percentage : ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }

}

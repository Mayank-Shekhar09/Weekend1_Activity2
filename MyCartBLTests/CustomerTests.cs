using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Assert.AreNotEqual(customer1, customer2);
        }
    }
}
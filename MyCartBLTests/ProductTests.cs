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
    public class ProductTests
    {
        [TestMethod()]
        public void ProductTest()
        {
            Product product1 = new Product();
            Product product2 = new Product();
            Assert.AreNotEqual(product1, product2);
        }
    }
}
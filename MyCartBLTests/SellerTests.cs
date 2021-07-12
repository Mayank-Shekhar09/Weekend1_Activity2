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
    public class SellerTests
    {
        [TestMethod()]
        public void SellerTest()
        {
            Seller seller1 = new Seller();
            Seller seller2 = new Seller();
            Assert.AreNotEqual(seller1, seller2);
        }
    }
}
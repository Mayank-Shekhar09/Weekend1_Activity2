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
    public class PurchaseTests
    {
        [TestMethod()]
        public void RoundOffBillTest()
        {
            var pur = new Purchase();
            double actual = pur.RoundOffBill(75.456);
            double expected = 75.46;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PurchaseTest()
        {
            Purchase purchase1 = new Purchase();
            Purchase purchase2 = new Purchase();
            Assert.AreNotEqual(purchase1, purchase2);
            Purchase purchase3 = new Purchase();
            Assert.AreNotEqual(purchase1, purchase2);
            Assert.AreNotEqual(purchase1, purchase3);
        }
    }
}
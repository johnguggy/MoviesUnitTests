using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieStore.Tests
{
    [TestClass]
    public class BusinessTest
    {
        [TestMethod]
        public void GetTaxPass()
        {
            //Arrange
            var bc = new Calc();

            //Act
            var taxAmt = bc.GetTax(10);
  
            //Assert
            Assert.AreEqual(taxAmt, 0.8);
        }
        [TestMethod]
        public void GetTaxFail()
        {
            //Arrange
            var bc = new Calc();

            //Act 
            var taxAmt = bc.GetTax(100);

            //Assert
            Assert.AreNotEqual(taxAmt, 8.01);
        }
        [TestMethod]
        public void GetTotalPass()
        {
            var bc = new Calc();

            var totalAmt = bc.GetTotal(100);

            Assert.AreEqual(totalAmt, 108);
        }
        [TestMethod]
        public void GetTotalFail()
        {
            //Arrange
            var bc = new Calc();

            //Act 
            var taxAmt = bc.GetTax(100);

            //Assert
            Assert.AreNotEqual(taxAmt, 8.01);
        }
    }
}

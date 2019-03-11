using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTestPositive()
        {
            //Arrange
            Calculator c = new Calculator();

            //Act
            int t1 = 12;
            int t2 = 8;
            int expectedResult = 20;
            int actualResult = c.Add(t1, t2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void AddTestNegative()
        {
            //Arrange
            Calculator c = new Calculator();

            //Act
            int t1 = -12;
            int t2 = -8;
            int expectedResult = -20;
            int actualResult = c.Add(t1, t2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MinusTest()
        {
            // Arrange
            Calculator c = new Calculator();

            //Act
            int t1 = 12;
            int t2 = 8;
            int expectedResult = 4;
            int actualResult = c.Minus(t1, t2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void GangeTest()
        {
            Assert.Fail();
        }
    }
}
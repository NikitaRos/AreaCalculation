using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaCalculation;
using System.Collections.Generic;

namespace UnitTestCalculation
{
    [TestClass]
    public class UnitTest1
    {
        Calculation calculation = new Calculation();
        [TestMethod]
        public void TestMethodCircle()
        {
            double x = 5;
            
            double answer = 78.54;
            double test = calculation.Circle(5);

            Assert.AreEqual(answer, test, "test is not correct");
        }

        [TestMethod]
        public void TestMethoodTriangle()
        {
            double x = 10;
            double y = 15;
            double z = 18;

            string answer = "75";
            List<String> test = calculation.Triangle(x, y, z);

            Assert.AreEqual(answer, test[0], "test is not correct");
        }

        [TestMethod]
        public void TestMethoodRightTriangle()
        {
            double x = 5;
            double y = 12;
            double z = 13;

            string answer = "30";
            List<String> test = calculation.Triangle(x, y, z);

            Assert.AreEqual(answer, test[0], "test is not correct");
        }
    }
}

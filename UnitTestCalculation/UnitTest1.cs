using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation;
using System.Collections.Generic;

namespace UnitTestCalculation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCircle()
        {
            double x = 5;
            Circle c = new Circle(x);
                        
            string answer = "78,54";
            List<String> test = c.Calculation();

            Assert.AreEqual(answer, test[0], "test is not correct");
        }

        [TestMethod]
        public void TestMethoodTriangle()
        {
            double x = 10;
            double y = 15;
            double z = 18;
            Triangle t = new Triangle(x, y, z);

            string answer = "75";
            List<String> test = t.Calculation();

            Assert.AreEqual(answer, test[0], "test is not correct");
        }

        [TestMethod]
        public void TestMethoodRightTriangle()
        {
            double x = 5;
            double y = 12;
            double z = 13;
            Triangle t = new Triangle(x, y, z);

            string answer = "30";
            List<String> test = t.Calculation();

            Assert.AreEqual(answer, test[0], "test is not correct");
        }
    }
}

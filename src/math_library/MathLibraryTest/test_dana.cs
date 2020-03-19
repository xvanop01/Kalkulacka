using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanaSimple;

namespace MathLibraryTest
{
    [TestClass]
    public class DanaSimpleTest
    {
        [TestMethod]
        public void TestPlus()
        {
            OperationsSimple dana = new OperationsSimple();
            Assert.AreEqual(5, dana.Plus(2, 3));
            Assert.AreEqual(3.14 + 4.125, dana.Plus(3.14, 4.125));
            Assert.AreEqual(-5, dana.Plus(5, -10));
            Assert.AreEqual(0, dana.Plus(0, 0));
            Assert.AreEqual(0, dana.Plus(5.456, -5.456));
            Assert.AreEqual(double.NaN, dana.Plus(double.NaN, 456));
            //Assert.AreEqual(double.PositiveInfinity, dana.Plus(0, double.PositiveInfinity)); // ak sa INF nebude dat zadat, tak netreba (1/0=NaN)
        }

        [TestMethod]
        public void TestMinus()
        {
            OperationsSimple dana = new OperationsSimple();
            Assert.AreEqual(5, dana.Minus(8, 3));
            Assert.AreEqual(3.14 - 4.125, dana.Minus(3.14, 4.125));
            Assert.AreEqual(15, dana.Minus(5, -10));
            Assert.AreEqual(0, dana.Minus(0, 0));
            Assert.AreEqual(0, dana.Minus(5.456, 5.456));
            Assert.AreEqual(-25.5, dana.Minus(-20, 5.5));
            Assert.AreEqual(double.NaN, dana.Minus(double.NaN, 456));
            //Assert.AreEqual(double.NegativeInfinity, dana.Minus(0, double.PositiveInfinity)); // ak sa INF nebude dat zadat, tak netreba (1/0=NaN)
        }

        [TestMethod]
        public void TestMulti()
        {
            OperationsSimple dana = new OperationsSimple();
            Assert.AreEqual(-4, dana.Multi(4, -1));
            Assert.AreEqual(0.5, dana.Multi(-8, -0.0625));
            Assert.AreEqual(-1.5, dana.Multi(-1, 1.5));
            Assert.AreEqual(0, dana.Multi(0.0, 465789123));
            Assert.AreEqual(65, dana.Multi(13, 5));
            Assert.AreEqual(double.NaN, dana.Multi(double.NaN, 456));
            //Assert.AreEqual(double.PositiveInfinity, dana.Multi(1, double.PositiveInfinity)); // ak sa INF nebude dat zadat, tak netreba (1/0=NaN)
        }

        [TestMethod]
        public void TestDiv()
        {
            OperationsSimple dana = new OperationsSimple();
            Assert.AreEqual(1.5, dana.Div(3, 2));
            Assert.AreEqual(-8, dana.Div(2, -0.25));
            Assert.AreEqual(double.NaN, dana.Div(7, 0.0)); // rovna sa NaN, nie INF pre jednoduchost
            Assert.AreEqual(1, dana.Div(-456.654, -456.654));
            Assert.AreEqual(-75, dana.Div(-100, 0.75));
            Assert.AreEqual(double.NaN, dana.Div(double.NaN, 456));
        }

        [TestMethod]
        public void TestFactorial()
        {
            OperationsSimple dana = new OperationsSimple();
            Assert.AreEqual(1, dana.Factorial(0));
            Assert.AreEqual(1, dana.Factorial(1));
            Assert.AreEqual(3628800, dana.Factorial(10));
            Assert.AreEqual(double.NaN, dana.Factorial(-7));
            Assert.AreEqual(6402373705728000, dana.Factorial(18));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanaSimple;
using DanaProfessional;

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

        [TestMethod]
        public void TestExp()
        {
            OperationsProfessional dana = new OperationsProfessional();
            Assert.AreEqual(1, dana.Exp(1, 45));
            Assert.AreEqual(1, dana.Exp(-59, 0));
            Assert.AreEqual(0.01, dana.Exp(10, -2));
            Assert.AreEqual(double.NaN, dana.Exp(0, 0));
            Assert.AreEqual(double.NaN, dana.Exp(0, -6));
            Assert.AreEqual(4, dana.Exp(-2, 2));
            Assert.AreEqual(-8, dana.Exp(-2, 3));
            Assert.AreEqual(0, dana.Exp(0, 987));
        }

        [TestMethod]
        public void TestRt()
        {
            OperationsProfessional dana = new OperationsProfessional();
            Assert.IsTrue(dana.Rt(2, 2) > 1.4142135623);
            Assert.IsTrue(dana.Rt(2, 2) < 1.4142135624);
            Assert.AreEqual(3, dana.Rt(27, 3));
            Assert.AreEqual(-4, dana.Rt(-64, 3));
            Assert.AreEqual(double.NaN, dana.Rt(-9, 4));
            Assert.AreEqual(double.NaN, dana.Rt(96, 0));
            Assert.AreEqual(1, dana.Rt(1, 67));
            Assert.AreEqual(0, dana.Rt(0, 3));
            Assert.AreEqual(double.NaN, dana.Rt(0, -9));
            Assert.AreEqual(0.25, dana.Rt(4, -1));
        }

        [TestMethod]
        public void TestAbs()
        {
            OperationsProfessional dana = new OperationsProfessional();
            Assert.AreEqual(0, dana.Abs(0));
            Assert.AreEqual(789, dana.Abs(789));
            Assert.AreEqual(357, dana.Abs(-357));
            Assert.AreEqual(1.424242, dana.Abs(-1.424242));
        }
    }
}

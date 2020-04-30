/**************************************************
 * Project name: Calculator
 * File: test_dana.cs
 * Date: 19.3.2020
 * Author: Peter Vaňo xvanop01(at)fit.vutbr.cz
 * 
 * Brief: Tests for Math library
 * 
 ***************************************************/

/*!
  \file test_dana.cs

  \brief Tests for Math library
  \author Peter Vaňo (xvanop01)
*/


using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanaSimple;
using DanaProfessional;

namespace MathLibraryTest
{
    //! OperationsSimple tests
    [TestClass]
    public class DanaSimpleTest
    {
        //! OperationsSimple.Plus tests
        [TestMethod]
        public void TestPlus()
        {
            Assert.AreEqual(5, OperationsSimple.Plus(2, 3));
            Assert.AreEqual(3.14 + 4.125, OperationsSimple.Plus(3.14, 4.125));
            Assert.AreEqual(-5, OperationsSimple.Plus(5, -10));
            Assert.AreEqual(0, OperationsSimple.Plus(0, 0));
            Assert.AreEqual(0, OperationsSimple.Plus(5.456, -5.456));
            Assert.AreEqual(double.NaN, OperationsSimple.Plus(double.NaN, 456));
            //Assert.AreEqual(double.PositiveInfinity, dana.Plus(0, double.PositiveInfinity)); // ak sa INF nebude dat zadat, tak netreba (1/0=NaN)
        }

        //! OperationsSimple.Minus tests
        [TestMethod]
        public void TestMinus()
        {
            Assert.AreEqual(5, OperationsSimple.Minus(8, 3));
            Assert.AreEqual(3.14 - 4.125, OperationsSimple.Minus(3.14, 4.125));
            Assert.AreEqual(15, OperationsSimple.Minus(5, -10));
            Assert.AreEqual(0, OperationsSimple.Minus(0, 0));
            Assert.AreEqual(0, OperationsSimple.Minus(5.456, 5.456));
            Assert.AreEqual(-25.5, OperationsSimple.Minus(-20, 5.5));
            Assert.AreEqual(double.NaN, OperationsSimple.Minus(double.NaN, 456));
            //Assert.AreEqual(double.NegativeInfinity, dana.Minus(0, double.PositiveInfinity)); // ak sa INF nebude dat zadat, tak netreba (1/0=NaN)
        }

        //! OperationsSimple.Multi tests
        [TestMethod]
        public void TestMulti()
        {
            Assert.AreEqual(-4, OperationsSimple.Multi(4, -1));
            Assert.AreEqual(0.5, OperationsSimple.Multi(-8, -0.0625));
            Assert.AreEqual(-1.5, OperationsSimple.Multi(-1, 1.5));
            Assert.AreEqual(0, OperationsSimple.Multi(0.0, 465789123));
            Assert.AreEqual(65, OperationsSimple.Multi(13, 5));
            Assert.AreEqual(double.NaN, OperationsSimple.Multi(double.NaN, 456));
            //Assert.AreEqual(double.PositiveInfinity, dana.Multi(1, double.PositiveInfinity)); // ak sa INF nebude dat zadat, tak netreba (1/0=NaN)
        }

        //! OperationsSimple.Div tests
        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(1.5, OperationsSimple.Div(3, 2));
            Assert.AreEqual(-8, OperationsSimple.Div(2, -0.25));
            Assert.AreEqual(double.NaN, OperationsSimple.Div(7, 0.0)); // rovna sa NaN, nie INF pre jednoduchost
            Assert.AreEqual(1, OperationsSimple.Div(-456.654, -456.654));
            Assert.AreEqual(-80, OperationsSimple.Div(-100, 1.25));
            Assert.AreEqual(double.NaN, OperationsSimple.Div(double.NaN, 456));
        }

        //! OperationsSimple.Factorial tests
        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(1, OperationsSimple.Factorial(0));
            Assert.AreEqual(1, OperationsSimple.Factorial(1));
            Assert.AreEqual(3628800, OperationsSimple.Factorial(10));
            Assert.AreEqual(double.NaN, OperationsSimple.Factorial(-7));
            Assert.AreEqual(6402373705728000, OperationsSimple.Factorial(18));
        }
    }

    //! OperationsProfessional tests
    [TestClass]
    public class DanaProfessional
    {
        //! OperationsProfessional.Exp tests
        [TestMethod]
        public void TestExp()
        {
            Assert.AreEqual(1, OperationsProfessional.Exp(1, 45));
            Assert.AreEqual(1, OperationsProfessional.Exp(-59, 0));
            Assert.AreEqual(0.01, OperationsProfessional.Exp(10, -2));
            Assert.AreEqual(double.NaN, OperationsProfessional.Exp(0, 0));
            Assert.AreEqual(double.NaN, OperationsProfessional.Exp(0, -6));
            Assert.AreEqual(4, OperationsProfessional.Exp(-2, 2));
            Assert.AreEqual(-8, OperationsProfessional.Exp(-2, 3));
            Assert.AreEqual(0, OperationsProfessional.Exp(0, 987));
        }

        //! OperationsProfessional.Rt tests
        [TestMethod]
        public void TestRt()
        {
            Assert.IsTrue(OperationsProfessional.Rt(2, 2) > 1.41421356237309);
            Assert.IsTrue(OperationsProfessional.Rt(2, 2) < 1.41421356237310);
            Assert.AreEqual(3, OperationsProfessional.Rt(27, 3));
            Assert.AreEqual(-4, OperationsProfessional.Rt(-64, 3));
            Assert.AreEqual(double.NaN, OperationsProfessional.Rt(-9, 4));
            Assert.AreEqual(double.NaN, OperationsProfessional.Rt(96, 0));
            Assert.AreEqual(1, OperationsProfessional.Rt(1, 67));
            Assert.AreEqual(0, OperationsProfessional.Rt(0, 3));
            Assert.AreEqual(double.NaN, OperationsProfessional.Rt(0, -9));
            Assert.AreEqual(0.25, OperationsProfessional.Rt(4, -1));
        }

        //! OperationsProfessional.Abs tests
        [TestMethod]
        public void TestAbs()
        {
            Assert.AreEqual(0, OperationsProfessional.Abs(0));
            Assert.AreEqual(789, OperationsProfessional.Abs(789));
            Assert.AreEqual(357, OperationsProfessional.Abs(-357));
            Assert.AreEqual(1.424242, OperationsProfessional.Abs(-1.424242));
        }
    }
}

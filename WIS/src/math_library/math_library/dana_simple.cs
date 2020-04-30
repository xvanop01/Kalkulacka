/**************************************************
 * Project name: Calculator
 * File: dana_simple.cs
 * Date: 20.3.2020
 * Author: Adriana Jurkechová xjurke02(at)fit.vutbr.cz
 * 
 * Brief: Math library
 * 
 ***************************************************/

/*!
  \file dana_simple.cs

  \brief Math library 
  \author Adriana Jurkechová (xjurke02)
*/


using System;

namespace DanaSimple
{
    //! Simple Math library class
    /*!
      Math library for operations Addition, Subtraction, Multiplication, Division and Factorial.
    */
    public static class OperationsSimple
    {
        //! Plus for Additon
        /*!
          \param a The first addent
          \param b the second addent
          \return Returns sum of addents
        */
        public static double Plus(double a, double b) // a + b
        {
            return a+b;
        }

        //!Minus for Substraction
        /*!
          \param a Minuend
          \param b Subtrahend
          \return Returns difference of terms
        */ 
        public static double Minus(double a, double b) // a - b
        {
            return a-b;
        }

        //! Multi for Multiplication
        /*!
          \param a Multiplier
          \param b Multiplicand
          \return Returns product of factors
        */
        public static double Multi(double a, double b) // a * b
        {
            return a*b;
        }

        //! Div for Division
        /*!
          \param a Dividend
          \param b Divisor
          \return Returns quotient
        */
        public static double Div(double a, double b) // a / b
        {
            if (b == 0)
                return double.NaN; //in case of divisor is 0, quotient will by NaN
            return a / b;
        }
        
        //! Factorial for Factorial
        /*!
          \param a Positive integer
          \return Returns product of factorial
        */
        public static double Factorial(int a) // a! 
        {
            if (a == 0 || a == 1) //0! and 1!
                return 1;
            else if (a < 0) 
                return double.NaN; //in case of negative parameter a, in will return NaN
            else
            {
                double result = 1;
                for (int i = 1; i <= a; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}
/**************************************************
 * Project name: Calculator
 * File: dana_professional.cs
 * Date: 19.3.2020
 * Author: Peter Vaňo xvanop01(at)fit.vutbr.cz
 * 
 * Brief: Extended Math library
 * 
 ***************************************************/

/*!
  \file dana_professional.cs

  \brief Extended Math library 
  \author Peter Vaňo (xvanop01)
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace DanaProfessional
{
    //! Extended Math library class
    /*!
      Math library for operations Exponentiation, n-th root, Absolute Value
    */
    public static class OperationsProfessional
    {
        //! Exp for Exponentiation
        /*!
          \param a Base
          \param b Exponent
          \return Returns power
        */
        public static double Exp(double a, int b) // a^b
        {
            if (b <= 0 && a == 0)
            {
                return double.NaN;
            }
            if (a == 1 || a == 0)
            {
                return a;
            }
            if (b == 0)
            {
                return 1;
            }
            double result = 1;
            double abs_b = Abs(b);
            for (int i = 0; i < abs_b; i++)
            {
                result = result * a;
            }
            if (b < 0)
            {
                return 1 / result;
            } else
            {
                return result;
            }
        }

        //! Rt for n-th root
        /*!
          param a Radicand
          param b Degree
          return Returns root
        */
        public static double Rt(double a, int b) // a^(1/b); na presnost 10^(-15)
        {
            double abs_a = Abs(a);
            int abs_b = b;
            if (abs_b < 0)
            {
                abs_b = -abs_b;
            }
            if ((abs_b % 2 == 0 && a < 0) || b == 0 || (b < 0 && a == 0))
            {
                return double.NaN;
            }
            if (a == 0 || a == 1 || b == 1)
            {
                return a;
            }
            if (b == -1)
            {
                return 1 / a;
            }
            double guess = abs_a;
            double check = 0;
            for (; guess - check > 1e-14 || check - guess > 1e-14; )
            {
                check = guess;
                guess = (1.0 / abs_b) * (((abs_b - 1) * check) + (abs_a / Exp(check, (abs_b - 1))));
            }
            if (b < 0)
            {
                guess = 1 / guess;
            }
            if (a < 0)
            {
                guess = -guess;
            }
            return guess;
        }

        //! Abs for Absolute value
        /*!
          \param a Positive or negative number
          \return Returns an ansolute value from parameter a
        */
        public static double Abs(double a) // |a|
        {
            if (a < 0)
            {
                return -a;
            } else
            {
                return a;
            }
        }
    }
}

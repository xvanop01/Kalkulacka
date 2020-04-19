using System;
using System.Collections.Generic;
using System.Text;

namespace DanaProfessional
{
    public static class OperationsProfessional
    {
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

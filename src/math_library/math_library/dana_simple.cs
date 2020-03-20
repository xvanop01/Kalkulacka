using System;

namespace DanaSimple
{
    public class OperationsSimple
    {
        public double Plus(double a, double b) // a + b
        {
            return a+b;
        }

        public double Minus(double a, double b) // a - b
        {
            return a-b;
        }

        public double Multi(double a, double b) // a * b
        {
            return a*b;
        }

        public double Div(double a, double b) // a / b
        {
            if (b == 0)
                return double.NaN;
            return a / b;
        }
        
        public double Factorial(int a) // a! // existuje aj faktorial floatu, chceme aj to riesit?
        {
            if (a == 0 || a == 1)
                return 1;
            else if (a < 0)
                return double.NaN;
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
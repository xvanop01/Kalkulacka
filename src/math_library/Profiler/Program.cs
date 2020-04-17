using System;
using DanaProfessional;
using DanaSimple;

namespace Profiler
{
    public class Suma
    {
        public double xi_sum;
        public double xi_2sum;
        public double counter;
        public double result;

        public Suma()
        {
            xi_sum = 0;
            xi_2sum = 0;
            counter = 0;
            result = 0;
        }

        public void Deviation()
        {
            if (counter == 0 || counter == 1)
            {
                result = 0;
            }
            else
            {
                double first_part = OperationsSimple.Div(1, OperationsSimple.Minus(counter, 1));
                // Console.WriteLine(first_part);
                double last_part = OperationsSimple.Div(xi_sum, counter);
                last_part = OperationsProfessional.Exp(last_part, 2);
                last_part = OperationsSimple.Multi(last_part, counter);
                // Console.WriteLine(last_part);
                // Console.WriteLine(xi_2sum);
                double xi2_xi = OperationsSimple.Minus(xi_2sum, last_part);
                double under_sqrt = OperationsSimple.Multi(first_part, xi2_xi);
                // Console.WriteLine(under_sqrt);
                result = OperationsProfessional.Rt(under_sqrt, 2);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Suma work_suma = new Suma();
            string line;
            string number = "";
            double new_x;
            while (!String.IsNullOrEmpty(line = Console.ReadLine()))
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsWhiteSpace(line[i]))
                    {
                        if (String.IsNullOrEmpty(number))
                        {
                            continue;
                        }
                        new_x = double.Parse(number);
                        work_suma.xi_sum += new_x;
                        new_x = OperationsProfessional.Exp(new_x, 2);
                        work_suma.xi_2sum += new_x;
                        work_suma.counter++;
                        number = "";
                        continue;
                    }
                    number += line[i];
                }
                if (String.IsNullOrEmpty(number))
                {
                    continue;
                }
                new_x = double.Parse(number);
                work_suma.xi_sum += new_x;
                new_x = OperationsProfessional.Exp(new_x, 2);
                work_suma.xi_2sum += new_x;
                work_suma.counter++;
                number = "";
            }
            work_suma.Deviation();
            Console.WriteLine(work_suma.result);
        }
    }
}

using System;
using System.Diagnostics;
using DanaProfessional;
using DanaSimple;

namespace Profiler
{
    //! Profiler handler
    /*! Contains variables to store profiler's stats */
    public class ProfilerCounters
    {
        public Stopwatch stopWatch = new Stopwatch();
        public TimeSpan plus;          /*!< Stores total time spent in OperationsSimple.Plus */
        public TimeSpan minus;         /*!< Stores total time spent in OperationsSimple.Minus */
        public TimeSpan div;           /*!< Stores total time spent in OperationsSimple.Div */
        public TimeSpan multi;         /*!< Stores total time spent in OperationsSimple.Multi */
        public TimeSpan factorial;     /*!< Stores total time spent in OperationsSimple.Factorial */
        public TimeSpan exp;           /*!< Stores total time spent in OperationsSimple.Exp */
        public TimeSpan rt;            /*!< Stores total time spent in OperationsSimple.Rt */
        public TimeSpan abs;           /*!< Stores total time spent in OperationsSimple.Abs */
        public int cPlus;              /*!< Stores how many times was OperationsSimple.Plus called */
        public int cMinus;             /*!< Stores how many times was OperationsSimple.Minus called */
        public int cDiv;               /*!< Stores how many times was OperationsSimple.Div called */
        public int cMulti;             /*!< Stores how many times was OperationsSimple.Multi called */
        public int cFactorial;         /*!< Stores how many times was OperationsSimple.Factorial called */
        public int cExp;               /*!< Stores how many times was OperationsSimple.Exp called */
        public int cRt;                /*!< Stores how many times was OperationsSimple.Rt called */
        public int cAbs;               /*!< Stores how many times was OperationsSimple.Abs called */

        //! Formated output
        /*! Prints and counts statistics from profiler */
        public void GetStats()
        {
            Console.WriteLine();
            Console.WriteLine("########## PROFILER'S START ##########");

            Console.WriteLine("[ms] Time in the OperationsSimple.Plus:                       " + plus.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsSimple.Plus:                    " + cPlus);
            if (cPlus != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsSimple.Plus:      " + (plus / cPlus).TotalMilliseconds);
            Console.WriteLine("#####");

            Console.WriteLine("[ms] Time in the OperationsSimple.Minus:                      " + minus.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsSimple.Minus:                   " + cMinus);
            if (cMinus != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsSimple.Minus:     " + (minus / cMinus).TotalMilliseconds);
            Console.WriteLine("#####");

            Console.WriteLine("[ms] Time in the OperationsSimple.Multi:                      " + multi.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsSimple.Multi:                   " + cMulti);
            if (cMulti != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsSimple.Multi:     " + (multi / cMulti).TotalMilliseconds);
            Console.WriteLine("#####");

            Console.WriteLine("[ms] Time in the OperationsSimple.Div:                        " + div.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsSimple.Div:                     " + cDiv);
            if (cDiv != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsSimple.Div:       " + (div / cDiv).TotalMilliseconds);
            Console.WriteLine("#####");

            Console.WriteLine("[ms] Time in the OperationsSimple.Factorial:                  " + factorial.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsSimple.Factorial:               " + cFactorial);
            if (cFactorial != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsSimple.Factorial: " + (factorial / cFactorial).TotalMilliseconds);
            Console.WriteLine("#####");

            Console.WriteLine("[ms] Time in the OperationsProfesional.Exp:                   " + exp.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsProfesional.Exp:                " + cExp);
            if (cExp != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsProfesional.Exp:  " + (exp / cExp).TotalMilliseconds);
            Console.WriteLine("#####");

            Console.WriteLine("[ms] Time in the OperationsProfesional.Rt:                    " + rt.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsProfesional.Rt:                 " + cRt);
            if (cRt != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsProfesional.Rt:   " + (rt / cRt).TotalMilliseconds);
            Console.WriteLine("#####");

            Console.WriteLine("[ms] Time in the OperationsProfesional.Abs:                   " + abs.TotalMilliseconds);
            Console.WriteLine("     Total calls of OperationsProfesional.Abs:                " + cAbs);
            if (cAbs != 0)
                Console.WriteLine("[ms] Average time per one call of OperationsProfesional.Abs:  " + (abs / cAbs).TotalMilliseconds);
            Console.WriteLine("##########  PROFILER'S END  ##########");
        }
    }

    //! Sum handler
    /*! Contains methods and variables for counting Sum */
    public class Suma
    {
        public double xi_sum;    /*!< Sum of x1 to xn */
        public double xi_2sum;   /*!< Sum of x1^2 to xn^2 */
        public double counter;   /*!< Counts number of xi (n) */
        public double result;    /*!< Store result of deviation */

	      //! Constructor
	      /*! Set variables to zero */
        public Suma()
        {
            xi_sum = 0;
            xi_2sum = 0;
            counter = 0;
            result = 0;
        }

        //! Deviation counter
	      /*! Counts deviation from stored values
            \param profiler Profiler with stored values
        */
        public void Deviation(ProfilerCounters profiler)
        {
            if (counter == 0 || counter == 1)
            {
                result = 0;
            }
            else
            {
                double c1;
                double first_part;
                double last_part;
                double xi2_xi;
                double under_sqrt;

                profiler.stopWatch.Start();
                c1 = OperationsSimple.Minus(counter, 1); // c1 = n-1
                profiler.stopWatch.Stop();
                profiler.minus += profiler.stopWatch.Elapsed;
                profiler.cMinus++;

                profiler.stopWatch.Start();
                first_part = OperationsSimple.Div(1, c1); // first_part = 1/(n-1)
                profiler.stopWatch.Stop();
                profiler.div += profiler.stopWatch.Elapsed;
                profiler.cDiv++;

                // Console.WriteLine(first_part);
                profiler.stopWatch.Start();
                last_part = OperationsSimple.Div(xi_sum, counter); // last_part = Sum(x)/n
                profiler.stopWatch.Stop();
                profiler.div += profiler.stopWatch.Elapsed;
                profiler.cDiv++;

                profiler.stopWatch.Start();
                last_part = OperationsProfessional.Exp(last_part, 2); // last_part = (Sum(x)/n)^2
                profiler.stopWatch.Stop();
                profiler.exp += profiler.stopWatch.Elapsed;
                profiler.cExp++;

                profiler.stopWatch.Start();
                last_part = OperationsSimple.Multi(last_part, counter); // last_part = (Sum(x)/n)^2 / n
                profiler.stopWatch.Stop();
                profiler.multi += profiler.stopWatch.Elapsed;
                profiler.cMulti++;

                // Console.WriteLine(last_part);
                // Console.WriteLine(xi_2sum);
                profiler.stopWatch.Start();
                xi2_xi = OperationsSimple.Minus(xi_2sum, last_part); // xi2_xi = Sum(x^2) - (((Sum(x)/n)^2) / n)
                profiler.stopWatch.Stop();
                profiler.minus += profiler.stopWatch.Elapsed;
                profiler.cMinus++;

                profiler.stopWatch.Start();
                under_sqrt = OperationsSimple.Multi(first_part, xi2_xi); // under_sqrt = (1/(n-1)) * (Sum(x^2) - (((Sum(x)/n)^2) / n))
                profiler.stopWatch.Stop();
                profiler.multi += profiler.stopWatch.Elapsed;
                profiler.cMulti++;

                // Console.WriteLine(under_sqrt);
                profiler.stopWatch.Start();
                result = OperationsProfessional.Rt(under_sqrt, 2); // result = ((1/(n-1)) * (Sum(x^2) - (((Sum(x)/n)^2) / n)))^(1/2)
                profiler.stopWatch.Stop();
                profiler.rt += profiler.stopWatch.Elapsed;
                profiler.cRt++;
            }
        }
    }

    //! Executable
    /*! Console app's class */
    class Program
    {

        //! Main of console app
        /*!
            \param args Not used, program isn't supporting args
        */
        static void Main(string[] args)
        {
            ProfilerCounters counter = new ProfilerCounters();
            Suma work_suma = new Suma();
            string line; // loaded line
            string number = ""; // number as a string
            double new_x; // currectly handled x
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

                        counter.stopWatch.Start();
                        work_suma.xi_sum = OperationsSimple.Plus(work_suma.xi_sum, new_x);
                        counter.stopWatch.Stop();
                        counter.plus += counter.stopWatch.Elapsed;
                        counter.cPlus++;

                        counter.stopWatch.Start();
                        new_x = OperationsProfessional.Exp(new_x, 2);
                        counter.stopWatch.Stop();
                        counter.exp += counter.stopWatch.Elapsed;
                        counter.cExp++;

                        counter.stopWatch.Start();
                        work_suma.xi_2sum = OperationsSimple.Plus(work_suma.xi_2sum, new_x);
                        counter.stopWatch.Stop();
                        counter.plus += counter.stopWatch.Elapsed;
                        counter.cPlus++;

                        counter.stopWatch.Start();
                        work_suma.counter = OperationsSimple.Plus(work_suma.counter, 1);
                        counter.stopWatch.Stop();
                        counter.plus += counter.stopWatch.Elapsed;
                        counter.cPlus++;

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

                counter.stopWatch.Start();
                work_suma.xi_sum = OperationsSimple.Plus(work_suma.xi_sum, new_x);
                counter.stopWatch.Stop();
                counter.plus += counter.stopWatch.Elapsed;
                counter.cPlus++;

                counter.stopWatch.Start();
                new_x = OperationsProfessional.Exp(new_x, 2);
                counter.stopWatch.Stop();
                counter.exp += counter.stopWatch.Elapsed;
                counter.cExp++;

                counter.stopWatch.Start();
                work_suma.xi_2sum = OperationsSimple.Plus(work_suma.xi_2sum, new_x);
                counter.stopWatch.Stop();
                counter.plus += counter.stopWatch.Elapsed;
                counter.cPlus++;

                counter.stopWatch.Start();
                work_suma.counter = OperationsSimple.Plus(work_suma.counter, 1);
                counter.stopWatch.Stop();
                counter.plus += counter.stopWatch.Elapsed;
                counter.cPlus++;

                number = "";
            }
            work_suma.Deviation(counter);
            Console.WriteLine(work_suma.result); // writes result of deviation
            counter.GetStats(); // writes profiler's output
        }
    }
}

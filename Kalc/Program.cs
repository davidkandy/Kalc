using System;
using System.Collections.Generic;

namespace Kalc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Operations kalc = new Operations();

            double ans;

            List<string> equation = new List<string>();


            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to Kalc");

            Console.WriteLine("Enter first number from your equation");
            string x = Console.ReadLine();
            int first = Convert.ToInt32(x);

            ans = first;
            equation.Add(x);

            Console.WriteLine("Enter operation sign");
            string operationSign = Console.ReadLine();
            equation.Add(operationSign);

            while (true)
            {
                kalc.operationType = kalc.OperationSign(operationSign);

                Console.WriteLine("Enter next numberb from your equation");
                string y = Console.ReadLine();
                int second = Convert.ToInt32(y);

                equation.Add(y);

                //Operations kalc = new Operations(first, second);
                ans = kalc.CalculateOperation(ans, second);

                Console.WriteLine("Enter operation sign");
                string Sign = Console.ReadLine();

                equation.Add(Sign);

                if (string.IsNullOrEmpty(Sign)) break;


                //bool b1 = string.IsNullOrEmpty(Sign);

                //if (!b1)
                //{
                //    kalc.operationType = kalc.OperationSign(Sign);
                //    continue;
                //}
            }

            //foreach (string eqn in equation)
            //{
            //    Console.Write(eqn);
            //}

            // I told you to google, it...You're a programmer man, you can't know all the properties by heart.
            for (int i = 0 ; i < equation.Count; i++)
            {
                // You're supposed to index the list, like this
                string eqn = equation[i];
                
                if (i > 0)
                {
                    Console.Write(" ");
                }

                Console.Write(eqn);
            }
            Console.WriteLine($"= {ans}");
            
            // Console.ReadKey();
            Again();
        }
        
        static void Again()
        {
            Console.WriteLine("Would you like to perform another calculation? y/n");
            string answer = Console.ReadLine();

            try
            {
                if (answer[0] == 'y' || answer[0] == 'Y')
                {
                    Console.WriteLine("\n");
                    Main(new string[0]);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

using System;

namespace Kalc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Operations kalc = new Operations();
            double ans;

            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to Kalc");

            Console.WriteLine("Enter first number from your equation");
            string x = Console.ReadLine();
            int first = Convert.ToInt32(x);

            ans = first;

            Console.WriteLine("Enter operation sign");
            string operationSign = Console.ReadLine();

            while (true)
            {
                kalc.operationType = kalc.OperationSign(operationSign);

                Console.WriteLine("Enter next numberb from your equation");
                string y = Console.ReadLine();
                int second = Convert.ToInt32(y);

                //Operations kalc = new Operations(first, second);
                ans = kalc.CalculateOperation(ans, second);

                Console.WriteLine("Enter operation sign");
                string Sign = Console.ReadLine();

                if (string.IsNullOrEmpty(Sign)) break;

                //bool b1 = string.IsNullOrEmpty(Sign);

                //if (!b1)
                //{
                //    kalc.operationType = kalc.OperationSign(Sign);
                //    continue;
                //}
            }
            Console.WriteLine(ans);

        }

    }
}

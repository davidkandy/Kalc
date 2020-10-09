using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello!");
            Console.Write("Welcome to Kalc");

            Console.Write("Enter first number from your equation");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter operation sign");
            //var op = Console.ReadLine();
            //kalc.operationType(op);


            Console.Write("Enter second number from your equation");
            int second = int.Parse(Console.ReadLine());

            Operations kalc = new Operations(first, second);
            kalc.CalculateOperation();
            Console.ReadLine();

        }
    }
}

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
            Operations Ops = new Operations();

            /*
             * Do you want me to step into it??
             * Give it a run, man.
             */

            Console.WriteLine("Hello! \n");
            Console.WriteLine("Welcome to Kalc \n");

            Console.Write("Enter first number from your equation \n");
            string x = Console.ReadLine();
            int first = Convert.ToInt32(x);

            Console.Write("Enter operation sign \n");
            string operationSign = Console.ReadLine();
            
            // Should be working now.
            // I have to move our session to tommorow.
            // Also maybe we should be starting by 5.
            // Late times like these can be a little busy back here.
            // 5 sounds okay for me
            // Just that the uncertainty of there being light here is high, but 5 will be better.
            // So how about 1pm then? Alright, 1pm it is 
            // 
            
            Ops.operationType = Ops.OperationSign(operationSign);
            //var op = Console.ReadLine();
            //kalc.operationType(op);



            Console.Write("Enter second number from your equation \n");
            string y = Console.ReadLine();
            int second = Convert.ToInt32(y);

            Operations kalc = new Operations(first, second);
            var answer = kalc.PerformOperation(first, second);
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}

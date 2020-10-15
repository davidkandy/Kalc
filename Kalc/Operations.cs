using System;

namespace Kalc
{
    class Operations
    {
        #region Props

        public int[] X { get; set; }
        public int[] Y { get; set; }
        public OperationType operationType { get; set; }
        public int numberInput { get; set; }
        #endregion

        #region Constructors
        public Operations (int[] a, int[] b)
        {
            X = a;
            Y = b;
        }

        public Operations()
        {
        }
        #endregion

        #region Methods
        public double PerformOperation(double X, double Y)
        {
            //long numberinput = this.numberInput;
            //while (numberinput >= 0 || numberinput <= 1000000000000000000)
            //{
            return CalculateOperation(X,Y);
            //}
            //return 0;

        }

        public OperationType OperationSign(string sign)
        {
            switch (sign)
            {
                case "+":
                    return OperationType.Add;
                case "-":
                    return OperationType.Subtract;
                case "*":
                    return OperationType.Multiply;
                case "/":
                    return OperationType.Divide;
                case "%":
                    return OperationType.Modulus;
                case "^":
                    return OperationType.Power;
                default:
                    throw new InvalidOperationException($"Invalid sign {sign}");
            }
        }

        // Divided numbers create decimal points.
        // Int can't always work.
        public double CalculateOperation(double X, double Y)
        {
            //var operation = new Operations(X, Y);

            try
            {
                //switch (operation.operationType)
                switch (this.operationType)
                {
                    case OperationType.Add:
                        return (X + Y);
                    case OperationType.Subtract:
                        return (X - Y);
                    case OperationType.Multiply:
                        return (X * Y);
                    case OperationType.Divide:
                        return (X / Y);
                    case OperationType.Modulus:
                        return (X % Y);
                    case OperationType.Power:
                        return Math.Pow(X,Y);
                    default:
                        throw new Exception($"Invalid Operation {operationType}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }
        #endregion
    }

}

using System;

namespace Kalc
{
    class Operations
    {
        #region Props

        public int X { get; set; }
        public int Y { get; set; }
        public OperationType operationType { get; set; }
        #endregion

        #region Constructors
        public Operations (int a, int b)
        {
            X = a;
            Y = b;
        }
        #endregion

        #region Methods
        public int CalculateOperation(Operations operation)
        {
            try
            {
                switch (operation.operationType)
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
                        return (int)Math.Pow(X,Y);
                    default:
                        throw new Exception($"Invalid Operation {operation.operationType}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }

}

namespace ConsoleApp1
{

    //Strategy pattern


    public class Calculator
    {
        private IOperation _operation;

        public void SetOperation(IOperation operation)
        {
            _operation = operation;
        }

        public double ExecuteOperation(double a, double b)
        {
            if (_operation == null)
            {
                throw new InvalidOperationException("Operation is not set.");
            }
            return _operation.Calculate(a, b);
        }
    }
}

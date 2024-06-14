using static ConsoleApp1.Operations;

namespace ConsoleApp1
{
    public sealed class OperationFactory
    {
        //Singleton skapar en ny instans av operationfactory.

        private static readonly OperationFactory instance = new OperationFactory();

        private OperationFactory() { }

        //Property för att öppna instansen.
        public static OperationFactory Instance
        {
            get { return instance; }
        }

        public IOperation CreateOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    return new AddOperation();
                case "-":
                    return new SubtractOperation();
                case "*":
                    return new MultiplyOperation();
                case "/":
                    return new DivideOperation();
                default:
                    return null;
            }
        }
    }
}

namespace CalcLibrary
{
    public class Calculator
    {
        private int result = 0;

        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");

            return a / b;
        }

        public void AllClear()
        {
            result = 0;
        }

        public int GetResult => result;

        public void AddToResult(int a, int b)
        {
            result = a + b;
        }
    }
}

namespace RestWithASPNET10.Services
{
    public class MathService
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;

        public decimal Subtraction(decimal firstNumber, decimal secondNumber) => firstNumber - secondNumber;

        public decimal Multiplication(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;

        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return firstNumber / secondNumber;
        }

        public decimal Mean(decimal firstNumber, decimal secondNumber) => (firstNumber + secondNumber) / 2;

        public double SquareRoot(decimal number)
        {
            if(number < 0)
                throw new ArgumentException("Number must be a positive value.");
            return Math.Sqrt((double)number);
        }
    }
}

namespace FactorialLibrary
{
    public class FactorialCalculator
    {
        public long Calculate(int number)
        {
            if (number < 0) throw new ArgumentException("Negative number not allowed");
            return number <= 1 ? 1 : number * Calculate(number - 1);
        }
    }
}
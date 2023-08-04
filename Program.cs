internal class Program
{
    private static void Main(string[] args)
    {
        //System.Math class to calculate and execute some mathematical functions

        double min = Math.Min(5.2, 6.9); //returns the lowest
        double max = Math.Max(5.2, 6.9); //returns the highest
        double pow = Math.Pow(10, 3); //returns the number power 3 -> 10 * 10 * 10
        double floor = Math.Floor(5.666); //returns the integer of the number so: 5
        double ceiling = Math.Ceiling(5.1); //returns the rounded up number: 6
        double round1 = Math.Round(5.4123); //returns the rounded number up or down depends on the mathematical rule -> 5.4: 4, 5.5: 6.
        double round2 = Math.Round(5.4162, 2); //returns the rounded number up or down depends on the mathematical rule but up to the digit of the second int parameter: 5.42
        double sign = Math.Sign(-5); //returns -1 if number < 0, 0 if number == 0, 1 if number > 0
        double abs = Math.Abs(-10); //returns the absolute value of the number: 10
        double divRem = Math.DivRem(10, 3, out int remainder); //returns quotient and provides remainder to the out parameter
        double sqrt = Math.Sqrt(10); //retuns square root value of the given number

        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(pow);
        Console.WriteLine(floor);
        Console.WriteLine(ceiling);
        Console.WriteLine(round1);
        Console.WriteLine(round2);
        Console.WriteLine(sign);
        Console.WriteLine(abs);
        Console.WriteLine(divRem+ ", out: " + remainder);
        Console.WriteLine(sqrt);

    }
}
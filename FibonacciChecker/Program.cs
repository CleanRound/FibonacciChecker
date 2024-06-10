public static class IntegerExtensions
{
    public static bool IsFibonacci(this int number)
    {
        if (number < 0)
            return false;

        bool IsPerfectSquare(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }

        int n1 = 5 * number * number + 4;
        int n2 = 5 * number * number - 4;

        return IsPerfectSquare(n1) || IsPerfectSquare(n2);
    }
}

class Program
{
    static void Main()
    {
        int[] testNumbers = { 0, 1, 2, 3, 4, 5, 13, 21, 22, 34, 55, 56 };

        foreach (var number in testNumbers)
        {
            Console.WriteLine($"{number} is Fibonacci: {number.IsFibonacci()}");
        }
    }
}


internal class Program
{
    static int SumOfDigits(int a, int b)
    {
        int c = 0;
        while (a > 0)
        {
            c += a % b;
            a /= b;
        }
        return c;
    }

    static void Main(string[] args)
    {
        for (int i = 1000; i <= 9999; i++)
        {
            int a = SumOfDigits(i, 10);
            int b = SumOfDigits(i, 12);
            int c = SumOfDigits(i, 16);

            if (a == b && b == c)
                Console.WriteLine(i);
        }
    }
}
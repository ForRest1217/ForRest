using System.Numerics;
class Program
{
    static BigInteger A(long a, long b)
    {
        if (a > b)
            return 1;
        if (a == b)
            return a;
        if (b - a == 1)
            return (BigInteger)a * b;

        long c = (a + b) / 2;
        return A(a, c) * A(c + 1, b);
    }

    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        Console.WriteLine(A(1, a));
    }
}
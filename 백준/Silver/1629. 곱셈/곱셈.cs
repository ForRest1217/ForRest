class Program
{
    static long a, b, c;

    static void Main()
    {
        int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        a = aa[0];
        b = aa[1];
        c = aa[2];

        Console.WriteLine(A(a, b));
    }

    static long A(long a, long b)
    {
        if (b == 0)
            return 1;

        long c = A(a, b / 2);
        long d = (c * c) % Program.c;

        if (b % 2 == 1)
            d = (d * a) % Program.c;

        return d;
    }
}
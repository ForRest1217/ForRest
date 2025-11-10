internal class Program
{
    static void Main(string[] args)
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine(Z(a[0], a[1], a[2]));
    }

    static int Z(int a, int b, int c)
    {
        if (a == 0)
            return 0;

        int d = (int)Math.Pow(2, a - 1);

        if (b < d && c < d)
            return Z(a - 1, b, c);
        else if (b < d && c >= d)
            return d * d + Z(a - 1, b, c - d);
        else if (b >= d && c < d)
            return 2 * d * d + Z(a - 1, b - d, c);
        else
            return 3 * d * d + Z(a - 1, b - d, c - d);
    }
}
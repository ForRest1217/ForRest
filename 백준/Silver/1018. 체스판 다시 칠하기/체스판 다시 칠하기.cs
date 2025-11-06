internal class Program
{
    static void Main(string[] args)
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        char[][] b = new char[a[0]][];

        for (int i = 0; i < a[0]; i++)
            b[i] = Console.ReadLine().ToCharArray();

        int c = int.MaxValue;

        for (int i = 0; i <= a[0] - 8; i++)
        {
            for (int j = 0; j <= a[1] - 8; j++)
            {
                int d = CountRepaints(b, i, j, 'W');
                int dd = CountRepaints(b, i, j, 'B');
                c = Math.Min(c, Math.Min(d, dd));
            }
        }

        Console.WriteLine(c);
    }

    static int CountRepaints(char[][] a, int b, int c, char d)
    {
        int e = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                char ee = ((i + j) % 2 == 0) ? d : (d == 'W' ? 'B' : 'W');
                if (a[b + i][c + j] != ee)
                    e++;
            }
        }

        return e;
    }
}
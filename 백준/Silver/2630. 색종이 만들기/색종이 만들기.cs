internal class Program
{
    static int e = 0;
    static int ee = 0;

    static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);
        int[,] b = new int[a, a];
        for (int i = 0; i < a; i++)
        {
            int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            for (int j = 0; j < a; j++)
            {
                b[i, j] = aa[j];
            }
        }

        Squre(b, 0, b.GetLength(0), 0, b.GetLength(1));

        Console.WriteLine(e);
        Console.WriteLine(ee);
    }

    static void Squre(int[,] a, int b, int bb, int c, int cc)
    {
        int first = a[b, c];
        bool isSame = true;

        for (int i = b; i < bb; i++)
        {
            for (int j = c; j < cc; j++)
            {
                if (a[i, j] != first)
                {
                    isSame = false;
                    break;
                }
            }
            if (!isSame)
                break;
        }

        if (isSame)
        {
            if (first == 0)
                e++;
            else
                ee++;

            return;
        }

        int d = (b + bb) / 2;
        int dd = (c + cc) / 2;

        Squre(a, b, d, c, dd);
        Squre(a, b, d, dd, cc);
        Squre(a, d, bb, c, dd);
        Squre(a, d, bb, dd, cc);
    }
}
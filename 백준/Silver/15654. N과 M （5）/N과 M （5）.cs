using System.Text;
class Program
{
    static int a, b;
    static int[] c, d;
    static bool[] e;
    static StringBuilder sb = new StringBuilder();

    static void Main()
    {
        int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        a = aa[0];
        b = aa[1];

        int[] aaa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        c = new int[a];
        for (int i = 0; i < a; i++)
            c[i] = aaa[i];

        Array.Sort(c);

        d = new int[b];
        e = new bool[a];

        A(0);
        Console.Write(sb);
    }

    static void A(int a)
    {
        if (a == b)
        {
            sb.AppendLine(string.Join(" ", d));
            return;
        }

        for (int i = 0; i < Program.a; i++)
        {
            if (!e[i])
            {
                e[i] = true;
                d[a] = c[i];

                A(a + 1);

                e[i] = false;
            }
        }
    }
}
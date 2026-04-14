using System.Text;

internal class Program
{
    static int a, b;
    static int[] c;
    static int[] d;
    static StringBuilder sb = new StringBuilder();

    static void Main()
    {
        int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        a = aa[0];
        b = aa[1];
        c = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        Array.Sort(c);
        d = new int[b];

        DFS(0, 0);

        Console.Write(sb.ToString());
    }

    static void DFS(int x, int y)
    {
        if (x == b)
        {
            for (int i = 0; i < b; i++)
            {
                sb.Append(d[i]).Append(' ');
            }
            sb.AppendLine();
            return;
        }

        int e = -1;
        for (int i = y; i < a; i++)
        {
            if (e == c[i])
                continue;

            d[x] = c[i];
            e = c[i];

            DFS(x + 1, i);

        }
    }
}
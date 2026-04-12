using System.Text;

internal class Program
{
    static int a, b;
    static int[] c;
    static bool[] visited;
    static int[] d;
    static StringBuilder sb = new StringBuilder();

    static void Main()
    {
        int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        a = aa[0];
        b = aa[1];

        c = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        Array.Sort(c);

        visited = new bool[a];
        d = new int[b];

        DFS(0);

        Console.Write(sb.ToString());
    }

    static void DFS(int x)
    {
        if (x == b)
        {
            for (int i = 0; i < b; i++)
                sb.Append(d[i] + " ");
            sb.AppendLine();
            return;
        }

        int prev = -1;

        for (int i = 0; i < a; i++)
        {
            if (visited[i] || prev == c[i])
                continue;

            visited[i] = true;
            d[x] = c[i];
            prev = c[i];

            DFS(x + 1);

            visited[i] = false;
        }
    }
}
internal class Program
{
    static int a;
    static int[,] b;
    static bool[,] visited;
    static int c;

    static int[] moveX = { 1, -1, 0, 0 };
    static int[] moveY = { 0, 0, 1, -1 };

    static void Main()
    {
        a = int.Parse(Console.ReadLine()!);
        b = new int[a, a];
        visited = new bool[a, a];

        for (int i = 0; i < a; i++)
        {
            string aa = Console.ReadLine()!;
            for (int j = 0; j < a; j++)
            {
                b[i, j] = int.Parse(aa[j].ToString());
            }
        }

        List<int> cc = new List<int>();
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (b[i, j] == 1 && !visited[i, j])
                {
                    c = 0;
                    DFS(i, j);
                    cc.Add(c);
                }
            }
        }

        cc.Sort();

        Console.WriteLine(cc.Count);
        foreach (int ccc in cc)
            Console.WriteLine(ccc);
    }

    static void DFS(int x, int y)
    {
        visited[x, y] = true;
        c++;

        for (int i = 0; i < 4; i++)
        {
            int xValue = x + moveX[i];
            int yValue = y + moveY[i];

            if (xValue >= 0 && yValue >= 0 && xValue < a && yValue < a
                && b[xValue, yValue] == 1 && !visited[xValue, yValue])
            {
                DFS(xValue, yValue);
            }
        }
    }
}
internal class Program
{
    static int a, b;
    static int[,] c;
    static int[,] d;

    static int[] moveX = { 1, -1, 0, 0 };
    static int[] moveY = { 0, 0, 1, -1 };

    static void Main()
    {
        int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        a = aa[0];
        b = aa[1];

        c = new int[a, b];
        d = new int[a, b];

        for (int i = 0; i < a; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < b; j++)
            {
                c[i, j] = int.Parse(line[j].ToString());
            }
        }

        BFS(0, 0);

        Console.WriteLine(d[a - 1, b - 1]);
    }

    static void BFS(int x, int y)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((x, y));
        d[x, y] = 1;

        while (queue.Count > 0)
        {
            var (cx, cy) = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int xValue = cx + moveX[i];
                int yValue = cy + moveY[i];

                if (xValue < 0 || yValue < 0 || xValue >= a || yValue >= b)
                    continue;

                if (c[xValue, yValue] == 0 || d[xValue, yValue] != 0)
                    continue;

                d[xValue, yValue] = d[cx, cy] + 1;
                queue.Enqueue((xValue, yValue));
            }
        }
    }
}
internal class Program
{
    static int[,] b;
    static bool[,] visited;

    static int[] moveX = { 1, -1, 0, 0 };
    static int[] moveY = { 0, 0, 1, -1 };

    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        b = new int[a[0], a[1]];
        visited = new bool[a[0], a[1]];

        for (int i = 0; i < a[1]; i++)
        {
            int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            for (int j = 0; j < a[0]; j++)
            {
                b[j, i] = aa[j];
            }
        }

        BFS(a);

        int c = 0;
        for (int i = 0; i < a[0]; i++)
        {
            for (int j = 0; j < a[1]; j++)
            {
                if (b[i, j] == 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
                c = Math.Max(c, b[i, j]);
            }
        }

        Console.WriteLine(c - 1);
    }

    static void BFS(int[] a)
    {
        Queue<(int x, int y)> queue = new Queue<(int, int)>();

        for (int i = 0; i < a[0]; i++)
        {
            for (int j = 0; j < a[1]; j++)
            {
                if (b[i, j] == 1)
                {
                    queue.Enqueue((i, j));
                    visited[i, j] = true;
                }
            }
        }

        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int xValue = x + moveX[i];
                int yValue = y + moveY[i];

                if (xValue < 0 || yValue < 0 ||
                    xValue >= a[0] || yValue >= a[1])
                    continue;

                if (!visited[xValue, yValue] && b[xValue, yValue] == 0)
                {
                    visited[xValue, yValue] = true;
                    b[xValue, yValue] = b[x, y] + 1;
                    queue.Enqueue((xValue, yValue));
                }
            }
        }
    }
}
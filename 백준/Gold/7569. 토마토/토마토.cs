internal class Program
{
    static int[,,] b;
    static bool[,,] visited;

    static int[] moveX = { 1, -1, 0, 0, 0, 0 };
    static int[] moveY = { 0, 0, 1, -1, 0, 0 };
    static int[] moveZ = { 0, 0, 0, 0, 1, -1 };

    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        b = new int[a[0], a[1], a[2]];
        visited = new bool[a[0], a[1], a[2]];

        for (int i = 0; i < a[2]; i++)
        {
            for (int j = 0; j < a[1]; j++)
            {
                int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                for (int k = 0; k < a[0]; k++)
                {
                    b[k, j, i] = aa[k];
                }
            }
        }

        BFS(a);

        int c = 0;
        for (int i = 0; i < a[2]; i++)
        {
            for (int j = 0; j < a[1]; j++)
            {
                for (int k = 0; k < a[0]; k++)
                {
                    if (b[k, j, i] == 0)
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                    c = Math.Max(c, b[k, j, i]);
                }
            }
        }

        Console.WriteLine(c - 1);
    }

    static void BFS(int[] a)
    {
        Queue<(int x, int y, int z)> queue = new Queue<(int, int, int)>();

        for (int i = 0; i < a[2]; i++)
        {
            for (int j = 0; j < a[1]; j++)
            {
                for (int k = 0; k < a[0]; k++)
                {
                    if (b[k, j, i] == 1)
                    {
                        queue.Enqueue((k, j, i));
                        visited[k, j, i] = true;
                    }
                }
            }
        }

        while (queue.Count > 0)
        {
            var (x, y, z) = queue.Dequeue();

            for (int i = 0; i < 6; i++)
            {
                int xValue = x + moveX[i];
                int yValue = y + moveY[i];
                int zValue = z + moveZ[i];

                if (xValue < 0 || yValue < 0 || zValue < 0 ||
                    xValue >= a[0] || yValue >= a[1] || zValue >= a[2])
                    continue;

                if (!visited[xValue, yValue, zValue] && b[xValue, yValue, zValue] == 0)
                {
                    visited[xValue, yValue, zValue] = true;
                    b[xValue, yValue, zValue] = b[x, y, z] + 1;
                    queue.Enqueue((xValue, yValue, zValue));
                }
            }
        }
    }
}

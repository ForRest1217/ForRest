using System.Text;

internal class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);
        int[,] b = new int[a, a];
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < a; i++)
        {
            int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            for (int j = 0; j < a; j++)
            {
                b[i, j] = aa[j];
            }
        }

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                for (int k = 0; k < a; k++)
                {
                    if (b[j, i] == 1 && b[i, k] == 1)
                        b[j, k] = 1;
                }
            }
        }

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                sb.Append(b[i, j] + " ");
            }
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}
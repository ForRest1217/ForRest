int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int c = b[0];        
    int[] d = b.Skip(1).ToArray();

    int e = 0;
    for (int j = 0; j < d.Length; j++)
    {
        for (int k = 0; k < j; k++)
        {
            if (d[k] > d[j])
            {
                e++;
            }
        }
    }

    Console.WriteLine($"{c} {e}");
}
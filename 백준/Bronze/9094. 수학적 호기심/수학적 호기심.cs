int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int c = 0;

    for (int j = 1; j < b[0]; j++)
    {
        for (int k = j + 1; k < b[0]; k++)
        {
            if ((j * j + k * k + b[1]) % (j * k) == 0)
                c++;
        }
    }

    Console.WriteLine(c);
}
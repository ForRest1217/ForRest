int a = int.Parse(Console.ReadLine());
int b = -1;
int c = 0;

for (int i = 1; i <= a; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int bb = 0;

    for (int j = 0; j < 3; j++)
    {
        for (int k = j + 1; k < 4; k++)
        {
            for (int l = k + 1; l < 5; l++)
            {
                int sum = aa[j] + aa[k] + aa[l];
                bb = Math.Max(bb, sum % 10);
            }
        }
    }

    if (bb >= b)
    {
        b = bb;
        c = i;
    }
}

Console.WriteLine(c);
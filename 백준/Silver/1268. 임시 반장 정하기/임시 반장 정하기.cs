int a = int.Parse(Console.ReadLine());
int[,] b = new int[a, 5];

for (int i = 0; i < a; i++)
{
    string[] c = Console.ReadLine().Split();
    for (int j = 0; j < 5; j++)
    {
        b[i, j] = int.Parse(c[j]);
    }
}

int d = 0;
int dd = 0;

for (int i = 0; i < a; i++)
{
    int e = 0;

    for (int j = 0; j < a; j++)
    {
        if (i == j) 
            continue;

        for (int k = 0; k < 5; k++)
        {
            if (b[i, k] == b[j, k])
            {
                e++;
                break;
            }
        }
    }

    if (e > d)
    {
        d = e;
        dd = i;
    }
}

Console.WriteLine(dd + 1); 
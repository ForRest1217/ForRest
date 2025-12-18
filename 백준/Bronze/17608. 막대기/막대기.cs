int a = int.Parse(Console.ReadLine());
int[] b = new int[a];
for (int i = 0; i < a; i++)
{
    b[i] = int.Parse(Console.ReadLine());
}

int c = 0;
int d = 0;
for (int i = a - 1; i >= 0; i--)
{
    if (b[i] > c)
    {
        d++;
        c = b[i];
    }
}

Console.WriteLine(d);
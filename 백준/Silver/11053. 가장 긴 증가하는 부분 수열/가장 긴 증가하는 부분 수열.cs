int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] c = new int[a];

for (int i = 0; i < a; i++)
    c[i] = 1;

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (b[j] < b[i])
        {
            c[i] = Math.Max(c[i], c[j] + 1);
        }
    }
}

int d = 0;
for (int i = 0; i < a; i++)
    d = Math.Max(d, c[i]);

Console.WriteLine(d);
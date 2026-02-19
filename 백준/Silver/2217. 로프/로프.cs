int a = int.Parse(Console.ReadLine());
int[] b = new int[a];

for (int i = 0; i < a; i++)
    b[i] = int.Parse(Console.ReadLine());

Array.Sort(b);

int c = 0;
for (int i = 0; i < a; i++)
{
    int aa = b[i] * (a - i);
    if (aa > c)
        c = aa;
}

Console.WriteLine(c);
int a = int.Parse(Console.ReadLine());
List<int> b = new List<int>(a);
long c = 0;
for (int i = 0; i < a; i++)
    b.Add(int.Parse(Console.ReadLine()));

b.Sort();
b.Reverse();

for (int i = 1; i <= a; i++)
{
    int aa = b[i - 1] - (i - 1);
    if (aa >= 0)
        c += aa;
}

Console.WriteLine(c);
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = 0;
HashSet<string> set = new HashSet<string>();

for (int i = 0; i < a[0]; i++)
{
    set.Add(Console.ReadLine());
}


for (int i = 0; i < a[1]; i++)
{
    if (set.Contains(Console.ReadLine()))
        b++;
}

Console.WriteLine(b);
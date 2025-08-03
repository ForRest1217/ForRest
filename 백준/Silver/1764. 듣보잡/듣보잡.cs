int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
string[] b = new string[a[0]];
string[] c = new string[a[1]];
for(int i = 0; i < a[0]; i++)
{
    b[i] = Console.ReadLine();
}
for (int i = 0; i < a[1]; i++)
{
    c[i] = Console.ReadLine();
}

HashSet<string> d = new HashSet<string>(b);
List<string> e = new List<string>();

foreach (var f in c)
{
    if (d.Contains(f))
        e.Add(f);
}
e.Sort();

Console.WriteLine(e.Count);
foreach (var f in e)
    Console.WriteLine(f);
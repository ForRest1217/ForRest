int a = int.Parse(Console.ReadLine());
List<int> c = new List<int>();
for (int i = 2; i <= a; i++)
{
    while (a % i == 0)
    {
        c.Add(i);
        a /= i;
    }
}
foreach (int b in c)
{
    Console.WriteLine(b);
}
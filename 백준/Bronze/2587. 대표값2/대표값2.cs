int[] a = new int[5];
for (int i = 0; i < 5; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}
int b = a.Sum() / 5;
int c = a.OrderBy(x => x).ToArray()[2];

Console.WriteLine(b);
Console.WriteLine(c);
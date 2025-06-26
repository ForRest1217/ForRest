int[] a = new int[9];
int cd = 0;
int cs = 0;
for (int i = 0; i < 9; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 9; i++)
{
    if (a[i] == a.Max())
    {
        cd = a[i];
        cs = i + 1;
    }
}
Console.WriteLine(cd);
Console.WriteLine(cs);
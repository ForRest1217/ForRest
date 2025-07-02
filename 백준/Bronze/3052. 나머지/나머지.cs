int[] a = new int[10];
int[] b = new int[10];
int c = 0;
bool d = false;
for (int i = 0; i < a.Length; i++)
{
    a[i] = int.Parse(Console.ReadLine());
    b[i] = a[i] % 42;
}
for (int i = 0; i < b.Length; i++)
{
    d = false;
    for (int j = 0; j < i; j++)
    {
        if (b[i] == b[j])
        {
            d = true;
            break;
        }
    }
    if (d == false)
    {
        c++;
    }
}
Console.WriteLine(c);
string[] a = Console.ReadLine().Split();
int b = 0;
char c = a[1][0];
for (int i = 1; i <= int.Parse(a[0]); i++)
{
    string aa = i.ToString();
    foreach (char aaa in aa)
    {
        if (c == aaa)
        {
            b++;
        }
    }
}
Console.WriteLine(b);
int a = int.Parse(Console.ReadLine());
string[] b = Console.ReadLine().Split();
int c = 0;
foreach (string d in b)
{
    int e = int.Parse(d);
    bool istrue = true;

    if (e < 2)
    {
        continue;
    }
    for (int i = 2; i <= Math.Sqrt(e); i++)
    {
        if (e % i == 0)
        {
            istrue = false;
            break;
        }
    }
    if (istrue)
    {
        c++;
    }
}
Console.WriteLine(c);
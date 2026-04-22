string a = Console.ReadLine()!;
long b = 0;

foreach (char aa in a)
{
    b = (b * 10 + int.Parse(aa.ToString())) % 20000303;
}

Console.WriteLine(b);
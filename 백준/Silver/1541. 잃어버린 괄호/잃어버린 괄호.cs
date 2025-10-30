string a = Console.ReadLine();
string[] b = a.Split('-');
int c = b[0].Split('+').Select(int.Parse).Sum();

for (int i = 1; i < b.Length; i++)
{
    int d = b[i].Split('+').Select(int.Parse).Sum();
    c -= d;
}

Console.WriteLine(c);
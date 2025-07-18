int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    string[] b = Console.ReadLine().Split();
    int c = int.Parse(b[0]);
    int d = int.Parse(b[1]);
    int e = int.Parse(b[2]);
    int f = e % c;
    int g = e / c + 1;
    if (f == 0)
    {
        f = c;
        g = e / c;
    }
    Console.WriteLine($"{f}{g:D2}");
}
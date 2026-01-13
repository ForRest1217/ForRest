int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = int.Parse(Console.ReadLine());

if (b.Contains(c))
{
    Console.WriteLine(0);
    return;
}

Array.Sort(b);

int d = 0;
int dd = 1001;

foreach (int bb in b)
{
    if (bb < c)
        d = bb;
    else if (bb > c)
    {
        dd = bb;
        break;
    }
}

Console.WriteLine((c - d) * (dd - c) - 1);
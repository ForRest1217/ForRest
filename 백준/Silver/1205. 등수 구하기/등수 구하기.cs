int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = new int[a[0]];

if (a[0] > 0)
{
    string[] input = Console.ReadLine().Split();
    for (int i = 0; i < a[0]; i++)
    {
        b[i] = int.Parse(input[i]);
    }
}

if (a[0] == a[2] && a[0] > 0 && a[1] <= b[a[0] - 1])
{
    Console.WriteLine(-1);
    return;
}

int c = 1;
for (int i = 0; i < a[0]; i++)
{
    if (b[i] > a[1])
        c++;
    else
        break;
}

Console.WriteLine(c);
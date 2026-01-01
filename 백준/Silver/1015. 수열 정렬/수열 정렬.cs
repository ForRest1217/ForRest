int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] aa = new int[a];
int[] bb = new int[a];
for (int i = 0; i < a; i++)
{
    aa[i] = b[i];
    bb[i] = aa[i];
}

Array.Sort(bb);

bool[] isit = new bool[a];
int[] c = new int[a];

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if (!isit[j] && aa[i] == bb[j])
        {
            c[i] = j;
            isit[j] = true;
            break;
        }
    }
}

Console.WriteLine(string.Join(" ", c));
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = new int[a[0] + 1];
int[] c = new int[a[0] + 1];

b[1] = 1;
b[2] = 0;
c[1] = 0;
c[2] = 1;

for (int i = 3; i <= a[0]; i++)
{
    b[i] = b[i - 1] + b[i - 2];
    c[i] = c[i - 1] + c[i - 2];
}

for (int i = 1; i <= a[1]; i++)
{
    int aa = a[1] - c[a[0]] * i;

    if (aa <= 0)
        continue;

    if (aa % b[a[0]] == 0)
    {
        int aaa = aa / b[a[0]];

        if (aaa <= i)
        {
            Console.WriteLine(aaa);
            Console.WriteLine(i);
            break;
        }
    }
}
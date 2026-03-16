int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(b);
foreach (int bb in b)
{
    if (bb <= a[1])
    {
        a[1] += 1;
    }
    else
    {
        break;
    }
}
Console.WriteLine(a[1]);
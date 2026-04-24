int[] a= Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int b = 0;
while (true)
{
    if (b % a[2] == 0)
    {
        if (b % (a[1] + 5) >= a[1])
        {
            Console.WriteLine(b);
            break;
        }

        if (b >= a[0] * a[1] + (a[0] - 1) * 5)
        {
            Console.WriteLine(b);
            break;
        }
    }

    b++;
}
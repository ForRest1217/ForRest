using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        Console.WriteLine(Facto(a));
    }

    static long Facto(long a)
    {
        if (a == 0 || a == 1) 
            return 1;
        return a * Facto(a - 1);
    }
}
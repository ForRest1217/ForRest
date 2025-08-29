int a = int.Parse(Console.ReadLine()); 

for (int t = 0; t < a; t++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    int c = 1;

    if (b[0] > b[1] - b[0])
        b[0] = b[1] - b[0]; 

    for (int i = 1; i <= b[0]; i++)
    {
        c = c * (b[1] - i + 1) / i;
    }

    Console.WriteLine(c);
}
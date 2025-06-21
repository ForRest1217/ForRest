while (true)
{
    string[] parts = Console.ReadLine().Split();

    int a = int.Parse(parts[0]);
    int b = int.Parse(parts[1]);

    if (a == 0 && b == 0)
        break;

    Console.WriteLine(a + b);
}
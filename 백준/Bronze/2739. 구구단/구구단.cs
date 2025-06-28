int n = int.Parse(Console.ReadLine());

for (int i = n; i < n + 1; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}
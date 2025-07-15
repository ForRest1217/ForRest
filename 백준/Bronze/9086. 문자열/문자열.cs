int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    string b = Console.ReadLine();
    Console.WriteLine($"{b[0]}{b[b.Length - 1]}");
}
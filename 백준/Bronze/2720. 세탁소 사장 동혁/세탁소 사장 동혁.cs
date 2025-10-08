int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());

    int c = b / 25; b %= 25;
    int cc = b / 10; b %= 10;
    int ccc = b / 5; b %= 5;
    int cccc = b;
    Console.WriteLine($"{c} {cc} {ccc} {cccc}");
}
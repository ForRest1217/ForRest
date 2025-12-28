int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int b3 = int.Parse(Console.ReadLine());

if (3 * a1 + 2 * a2 + a3 > 3 * b1 + 2 * b2 + b3)
    Console.WriteLine("A");
else if (3 * a1 + 2 * a2 + a3 < 3 * b1 + 2 * b2 + b3)
    Console.WriteLine("B");
else
    Console.WriteLine("T");
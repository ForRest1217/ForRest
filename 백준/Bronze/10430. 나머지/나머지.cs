int[] y = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = y[0];
int b = y[1];
int c = y[2];
Console.WriteLine((a + b) % c);
Console.WriteLine(((a % c) + (b % c)) % c);
Console.WriteLine((a * b) % c);
Console.WriteLine(((a % c) * (b % c)) % c);
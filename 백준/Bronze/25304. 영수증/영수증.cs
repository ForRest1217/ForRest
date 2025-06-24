int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int total = 0;
for (int i = 0; i < y; i++)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    total += a[0] * a[1];
}

if (total == x)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
int a = int.Parse(Console.ReadLine());
int[] b = new int[a];

for (int i = 0; i < a; i++)
    b[i] = int.Parse(Console.ReadLine());

if (b[1] - b[0] == b[2] - b[1])
{
    int d = b[1] - b[0];
    Console.WriteLine(b[a - 1] + d);
}
else
{
    int r = b[1] / b[0];
    Console.WriteLine(b[a - 1] * r);
}
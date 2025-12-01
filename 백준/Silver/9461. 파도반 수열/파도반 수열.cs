int a = int.Parse(Console.ReadLine());
long[] b = new long[101];

b[1] = b[2] = b[3] = 1;
b[4] = b[5] = 2;

for (int i = 6; i <= 100; i++)
{
    b[i] = b[i - 1] + b[i - 5];
}

while (a-- > 0)
{
    int c = int.Parse(Console.ReadLine());
    Console.WriteLine(b[c]);
}
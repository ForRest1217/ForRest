int a = int.Parse(Console.ReadLine());
int b = 1;

for (int i = 2; i <= a; i++)
{
    b *= i;
}

Console.WriteLine(b);
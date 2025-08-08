int a = int.Parse(Console.ReadLine());
int[] b = new int[1001]; 
b[1] = 1;
b[2] = 2;
for (int i = 3; i <= a; i++)
{
    b[i] = (b[i - 1] + b[i - 2]) % 10007;
}
Console.WriteLine(b[a]);
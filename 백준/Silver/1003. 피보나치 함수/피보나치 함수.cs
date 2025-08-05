int a = int.Parse(Console.ReadLine());
int[,] b = new int[41, 2];
b[0, 0] = 1; 
b[0, 1] = 0;
b[1, 0] = 0;
b[1, 1] = 1; 

for (int i = 2; i <= 40; i++)
{
    b[i, 0] = b[i - 1, 0] + b[i - 2, 0];
    b[i, 1] = b[i - 1, 1] + b[i - 2, 1];
}
for (int i = 0; i < a; i++)
{
    int c = int.Parse(Console.ReadLine());
    Console.WriteLine($"{b[c, 0]} {b[c, 1]}");
}
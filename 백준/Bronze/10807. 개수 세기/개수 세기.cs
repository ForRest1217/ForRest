int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < a; i++)
{
    if (b[i] == c)
    {
        count++;
    }
}
Console.WriteLine(count);
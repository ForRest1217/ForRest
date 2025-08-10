int a = int.Parse(Console.ReadLine());
if (a == 0)
{
    Console.WriteLine(0);
    return;
}

int b = (int)Math.Round(a * 0.15, MidpointRounding.AwayFromZero);
int[] arr = new int[a];
for (int i = 0; i < a; i++)
    arr[i] = int.Parse(Console.ReadLine());

Array.Sort(arr);
double c = arr.Skip(b).Take(a - b * 2).Average();
Console.WriteLine((int)Math.Round(c, MidpointRounding.AwayFromZero));
int a = int.Parse(Console.ReadLine());
int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] bb = Console.ReadLine().Split().Select(int.Parse).ToArray();

Array.Sort(b);
Array.Sort(bb);
Array.Reverse(bb);

int c = 0;
for (int i = 0; i < a; i++)
{
    c += b[i] * bb[i];
}

Console.WriteLine(c);
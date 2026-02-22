int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> list = new List<int>();

for (int i = 0; i < a[0]; i++)
    list.Add(b[i]);
for (int i = 0; i < a[1]; i++)
    list.Add(c[i]);

list.Sort();

Console.WriteLine(string.Join(" ", list));
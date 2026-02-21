int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
HashSet<int> hashSet = new HashSet<int>();
for (int i = 0; i < a; i++)
    hashSet.Add(b[i]);

List<int> list = new List<int>(hashSet);
list.Sort();

Console.WriteLine(string.Join(" ", list));
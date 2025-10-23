int a = int.Parse(Console.ReadLine());
HashSet<string> b = new HashSet<string>();

for (int i = 0; i < a; i++)
{
    string[] c = Console.ReadLine().Split();

    if (c[1] == "enter")
        b.Add(c[0]);
    else
        b.Remove(c[0]);
}

List<string> bb = b.OrderByDescending(x => x).ToList();

foreach (string bbb in bb)
    Console.WriteLine(bbb);
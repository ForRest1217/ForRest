    int a = int.Parse(Console.ReadLine());
    var list = new List<(int age, string name, int index)>();
    for (int i = 0; i < a; i++)
    {
        string[] b = Console.ReadLine().Split();
        list.Add((int.Parse(b[0]), b[1], i));
    }

    var d = list.OrderBy(p => p.age).ThenBy(p => p.index);
    foreach (var e in d)
    {
        Console.WriteLine($"{e.age} {e.name}");
    }
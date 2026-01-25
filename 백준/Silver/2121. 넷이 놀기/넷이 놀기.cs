    int a = int.Parse(Console.ReadLine());
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    List<(int x, int y)> list = new List<(int x, int y)>();
    HashSet<string> hashSet = new HashSet<string>();
    for (int i = 0; i < a; i++)
    {
        int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        hashSet.Add($"{aa[0]},{aa[1]}");
        list.Add((aa[0], aa[1]));
    }

    int c = 0;
    foreach ((int x, int y) xy in list)
    {
        string d = $"{xy.x + b[0]},{xy.y}";
        string dd = $"{xy.x},{xy.y + b[1]}";
        string ddd = $"{xy.x + b[0]},{xy.y + b[1]}";

        if (hashSet.Contains(d) && hashSet.Contains(dd) && hashSet.Contains(ddd))
            c++;
    }

    Console.WriteLine(c);

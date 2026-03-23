int a = int.Parse(Console.ReadLine());

while (a-- > 0)
{
    int aa = int.Parse(Console.ReadLine());
    Dictionary<string, int> dict = new Dictionary<string, int>();

    for (int i = 0; i < aa; i++)
    {
        string[] aaa = Console.ReadLine().Split();

        if (dict.ContainsKey(aaa[1]))
            dict[aaa[1]]++;
        else
            dict[aaa[1]] = 1;
    }

    int b = 1;
    foreach (var value in dict)
    {
        b *= (value.Value + 1);
    }

    Console.WriteLine(b - 1);
}
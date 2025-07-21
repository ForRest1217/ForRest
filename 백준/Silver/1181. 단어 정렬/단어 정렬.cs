int a = int.Parse(Console.ReadLine());
List<string> b = new List<string>();
for (int i = 0; i < a; i++)
{
    string bb = Console.ReadLine();
    b.Add(bb);
}
List<string> btwo = b.Distinct().ToList();
btwo.Sort(WordSort);
foreach (string c in btwo)
{
    Console.WriteLine(c);
}

static int WordSort(string aaa, string bbb)
{
    if (aaa.Length != bbb.Length)
    {
        return aaa.Length.CompareTo(bbb.Length);
    }
    return string.Compare(aaa, bbb);
}
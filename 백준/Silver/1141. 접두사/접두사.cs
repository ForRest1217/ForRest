int a = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
for (int i = 0; i < a; i++)
{
    list.Add(Console.ReadLine());
}
list.Sort(); 

int b = list.Count;
for (int i = 0; i < list.Count - 1; i++)
{
    if (list[i + 1].StartsWith(list[i]))
        b--;
}

Console.WriteLine(b);
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<(int student, int count, int index)> list = new List<(int, int, int)>();

int d = 0;
for (int i = 0; i < b; i++)
{
    bool isit = false;
    for (int j = 0; j < list.Count; j++)
    {
        if (list[j].student == c[i])
        {
            list[j] = (list[j].student, list[j].count + 1, list[j].index);
            isit = true;
            break;
        }
    }
    if (isit) 
        continue;   

    if (list.Count < a)
    {
        list.Add((c[i], 1, d++));
    }
    else
    {
        list.Sort((x, y) =>
        {
            int aa = x.count.CompareTo(y.count);
            if (aa == 0)
                return x.index.CompareTo(y.index);
            return aa;
        });

        list.RemoveAt(0);
        list.Add((c[i], 1, d++));
    }
}

List<int> listwo = listwo = list.Select(x => x.student).OrderBy(x => x).ToList();
Console.WriteLine(string.Join(" ", listwo));
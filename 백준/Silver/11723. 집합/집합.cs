using System.Text;

int a = int.Parse(Console.ReadLine());
HashSet<int> hash = new HashSet<int>();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < a; i++)
{
    var b = Console.ReadLine().Split();

    if (b[0] == "add" || b[0] == "remove" || b[0] == "check" || b[0] == "toggle")
    {
        int c = int.Parse(b[1]);
        switch (b[0])
        {
            case "add":
                hash.Add(c);
                break;

            case "remove":
                hash.Remove(c);
                break;

            case "check":
                if (hash.Contains(c))
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
                break;

            case "toggle":
                if (hash.Contains(c)) hash.Remove(c);
                else hash.Add(c);
                break;
        }
    }
    else if (b[0] == "all")
    {
        hash.Clear();
        for (int j = 1; j <= 20; j++)
            hash.Add(j);
    }
    else if (b[0] == "empty")
    {
        hash.Clear();
    }
}
Console.Write(sb.ToString());
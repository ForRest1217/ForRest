using System.Text;

StringBuilder sb = new StringBuilder();
string line;

while ((line = Console.ReadLine()) != null)
{
    if (line.Trim() == "") continue;

    string[] parts = line.Split();
    if (parts.Length < 2) continue;

    int a = int.Parse(parts[0]);
    int b = int.Parse(parts[1]);
    sb.AppendLine((a + b).ToString());
}

Console.Write(sb.ToString());
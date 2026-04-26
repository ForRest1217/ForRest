using System.Text;
string a = Console.ReadLine()!;
StringBuilder sb = new StringBuilder();

sb.Append(Convert.ToString(int.Parse(a[0].ToString()), 2));

for (int i = 1; i < a.Length; i++)
{
    sb.Append(Convert.ToString(int.Parse(a[i].ToString()), 2).PadLeft(3, '0'));
}

Console.WriteLine(sb.ToString());
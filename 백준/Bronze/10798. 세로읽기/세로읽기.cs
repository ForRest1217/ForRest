using System.Text;

string[] a = new string[5];
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 5; i++)
{
    a[i] = Console.ReadLine();
}


for (int j = 0; j < 15; j++)
{          
    for (int i = 0; i < 5; i++)
    {        
        if (a[i].Length > j)
        {
            sb.Append(a[i][j]);
        }
    }
}

Console.WriteLine(sb.ToString());
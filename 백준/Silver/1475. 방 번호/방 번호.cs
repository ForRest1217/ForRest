string a = Console.ReadLine();
int b = 0;
List<int> list = new List<int>();

foreach (char aa in a)
{
    int aaa = int.Parse(aa.ToString());
    list.Add(aaa);
}

for (int i = 0; i < 10; i++)
{
    if (i == 6 || i == 9)
        continue;

    int bb = list.Count(x => x == i);
    if (bb > b)
    {
        b = bb;
    }
}

int c = (list.Count(x => x == 6) + list.Count(x => x == 9) + 1)/ 2;
if(c > b)
{
    b = c;
}

Console.WriteLine(b);
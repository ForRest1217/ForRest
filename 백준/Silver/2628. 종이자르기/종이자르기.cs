int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = int.Parse(Console.ReadLine());
List<int> list = new List<int>(); 
List<int> listt = new List<int>();

list.Add(0);
list.Add(a[1]);
listt.Add(0);
listt.Add(a[0]);

for (int i = 0; i < b; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (aa[0] == 0)
        list.Add(aa[1]);
    else
        listt.Add(aa[1]);
}

list.Sort();
listt.Sort();

int c = 0;
for (int i = 1; i < list.Count; i++)
    c = Math.Max(c, list[i] - list[i - 1]);
int cc = 0;
for (int i = 1; i < listt.Count; i++)
    cc = Math.Max(cc, listt[i] - listt[i - 1]);

Console.WriteLine(c * cc);
 int a = int.Parse(Console.ReadLine());
string[] b = new string[a];
int c = 0;

for (int i = 0; i < a; i++)
    b[i] = Console.ReadLine();


for (int i = 1; i < a; i++)
{
    int[] bb = new int[26];

    foreach (char bbb in b[0])
        bb[bbb - 65]++;

    foreach (char bbb in b[i])
        bb[bbb - 65]--;

    int cc = 0;
    for (int j = 0; j < 26; j++)
        cc += Math.Abs(bb[j]);

    int ccc = Math.Abs(b[0].Length - b[i].Length);

    if (cc == 0 || cc == 1 || (cc == 2 && ccc == 0))
        c++;
}

Console.WriteLine(c);
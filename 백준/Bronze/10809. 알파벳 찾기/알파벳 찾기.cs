string a = Console.ReadLine();
int[] b = new int[26];
int c = 0;
for (int i = 0; i < 26; i++)
{
    b[i] = -1;
}
foreach (char d in a)
{
    int e = d - 'a';
    if (b[e] == -1)
    {
        b[e] = c;
    }
    c++;
}
for (int i = 0; i < 26; i++)
{
    Console.Write(b[i] + " ");
}
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = a * b * c;
string e = d.ToString();
int[] sutja = new int[10];
foreach (char fff in e)
{
    int ggg = fff - '0'; //아스키코드 ('0'은 아스키코드에서 48)
    sutja[ggg]++;
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(sutja[i]);
}
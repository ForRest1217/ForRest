string a = Console.ReadLine();
int b = a.IndexOf('*');
int c = a[12] - '0';
int d = 0;

for (int i = 0; i < 12; i++)
{
    if (i == b)
        continue;
    int e = (i % 2 == 0) ? 1 : 3;
    d += (a[i] - '0') * e;
}
int f = (10 - ((d + c) % 10)) % 10;
int g = (b % 2 == 0) ? 1 : 3;
int h = (g == 1) ? f : (f * 7) % 10;
Console.WriteLine(h);
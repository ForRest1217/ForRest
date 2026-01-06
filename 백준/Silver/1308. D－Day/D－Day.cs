int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

bool isit = false;
if (a[0] + 1000 < b[0])
    isit = true;
else if (a[0] + 1000 == b[0])
{
    if (a[1] < b[1])
        isit = true;
    else if (a[1] == b[1] && a[2] <= b[2])
        isit = true;
}
if (isit)
{
    Console.WriteLine("gg");
    return;
}

int[] c = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
long d = 0;
long dd = 0;

for (int y = 1; y < a[0]; y++)
    d += (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0)) ? 366 : 365;

for (int m = 1; m < a[1]; m++)
    d += (m == 2 && (a[0] % 400 == 0 || (a[0] % 4 == 0 && a[0] % 100 != 0)))
        ? 29 : c[m];

d += a[2];


for (int y = 1; y < b[0]; y++)
    dd += (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0)) ? 366 : 365;

for (int m = 1; m < b[1]; m++)
    dd += (m == 2 && (b[0] % 400 == 0 || (b[0] % 4 == 0 && b[0] % 100 != 0)))
        ? 29 : c[m];

dd += b[2];

Console.WriteLine($"D-{dd - d}");
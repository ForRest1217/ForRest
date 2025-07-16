string[] a = Console.ReadLine().Split();
string b = a[0];
string c = a[1];
string d = $"{b[2]}" + b[1] + b[0];
string e = $"{c[2]}" + c[1] + c[0];
int f = int.Parse(d);
int g = int.Parse(e);
if (f > g)
    Console.WriteLine($"{f}");
else if (f < g)
    Console.WriteLine($"{g}");
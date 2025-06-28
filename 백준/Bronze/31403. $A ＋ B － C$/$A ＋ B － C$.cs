int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

Console.WriteLine(a + b - c);
string ab = a.ToString() + b.ToString();
int abnum = int.Parse(ab);
int result = abnum - c;
Console.WriteLine(result);
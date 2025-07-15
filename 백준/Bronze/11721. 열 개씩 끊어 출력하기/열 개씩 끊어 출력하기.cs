string a = Console.ReadLine();
for (int i = 0; i < a.Length; i += 10)
{
    int b = Math.Min(10, a.Length - i);
    Console.WriteLine(a.Substring(i, b));
}
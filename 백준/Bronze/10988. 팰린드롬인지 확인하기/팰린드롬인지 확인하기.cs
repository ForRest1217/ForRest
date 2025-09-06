string a = Console.ReadLine();
bool isit = true;

for (int i = 0; i < a.Length / 2; i++)
{
    if (a[i] != a[a.Length - i - 1])
    {
        isit = false;
        break;
    }
}
Console.WriteLine(isit ? 1 : 0);
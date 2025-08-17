int a = int.Parse(Console.ReadLine());
int b = 666;
int c = 0;
while (true)
{
    if (b.ToString().Contains("666"))
    {
        c++;
        if (c == a)
        {
            Console.WriteLine(b);
            break;
        }
    }
    b++;
}
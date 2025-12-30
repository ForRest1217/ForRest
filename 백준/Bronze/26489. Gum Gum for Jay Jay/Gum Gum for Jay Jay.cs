int a = 0;
string b = "";
while (b != null)
{
    b = Console.ReadLine();

    if (b == "gum gum for jay jay")
        a++;
    else
        break;
}
Console.WriteLine(a);
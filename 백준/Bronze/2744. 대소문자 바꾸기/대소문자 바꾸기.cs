string aa = Console.ReadLine();
string cc = "";
foreach (char bbb in aa)
{
    if (char.IsUpper(bbb))
    {
        cc += char.ToLower(bbb);
    }
    else if (char.IsLower(bbb))
    {
        cc += char.ToUpper(bbb);
    }
}
Console.WriteLine(cc);
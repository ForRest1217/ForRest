internal class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()!);

        if (a % 7 == 0 || a % 7 == 2)
            Console.WriteLine("CY");
        else
            Console.WriteLine("SK");
    }
}
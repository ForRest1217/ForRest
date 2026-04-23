string[] aa = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
int a = Array.IndexOf(aa, Console.ReadLine());
int b = Array.IndexOf(aa, Console.ReadLine());
int c = Array.IndexOf(aa, Console.ReadLine());
Console.WriteLine((long)((a * 10 + b) * Math.Pow(10, c)));
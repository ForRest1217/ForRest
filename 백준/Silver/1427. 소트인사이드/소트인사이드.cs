string input = Console.ReadLine();
var result = input.OrderByDescending(c => c).ToArray();
Console.WriteLine(new string(result));
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
DateTime b = new DateTime(2007, a[0], a[1]);
string[] c = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
Console.WriteLine(c[(int)b.DayOfWeek]);
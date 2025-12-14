int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
DateTime date = new DateTime(2009, a[1], a[0]);
Console.WriteLine(date.DayOfWeek);
using System.Numerics;
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
BigInteger b = BigInteger.Parse(Console.ReadLine());
BigInteger c = BigInteger.Parse(Console.ReadLine());
Console.WriteLine(b * c);
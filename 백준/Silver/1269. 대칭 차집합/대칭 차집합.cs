int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

HashSet<int> hashSetA = new HashSet<int>(b);
HashSet<int> hashSetB = new HashSet<int>(c);

HashSet<int> hashSetAA = new HashSet<int>(hashSetA);
hashSetAA.ExceptWith(hashSetB);
HashSet<int> hashSetBB = new HashSet<int>(hashSetB);
hashSetBB.ExceptWith(hashSetA);

Console.WriteLine(hashSetAA.Count + hashSetBB.Count);
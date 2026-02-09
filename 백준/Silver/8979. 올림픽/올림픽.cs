int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<(int num, int gold, int silver, int bronze)> list = new List<(int num, int gold, int silver, int bronze)>();

for (int i = 0; i < a[0]; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((aa[0], aa[1], aa[2], aa[3]));
}

(int num, int gold, int silver, int bronze) b = list.First(bb => bb.num == a[1]);

int c = list.Count(cc => cc.gold > b.gold ||
   (cc.gold == b.gold && cc.silver > b.silver) ||
   (cc.gold == b.gold && cc.silver == b.silver 
   && cc.bronze > b.bronze)) + 1;

Console.WriteLine(c);
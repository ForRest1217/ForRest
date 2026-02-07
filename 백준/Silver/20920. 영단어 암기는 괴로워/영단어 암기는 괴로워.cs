using System.Text;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();

int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
Dictionary<string, int> dictionary = new Dictionary<string, int>();

for (int i = 0; i < a[0]; i++)
{
    string word = sr.ReadLine();
    if (word.Length < a[1]) 
        continue;

    if (dictionary.ContainsKey(word))
        dictionary[word]++;
    else
        dictionary[word] = 1;
}

var b = dictionary.Keys
    .OrderByDescending(w => dictionary[w])
    .ThenByDescending(w => w.Length)
    .ThenBy(w => w, StringComparer.Ordinal);

foreach (var bb in b)
    sb.AppendLine(bb);

sw.Write(sb.ToString());
sw.Flush();
int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] dp = new int[a];
for (int i = 0; i < a; i++)
    dp[i] = 1;
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (b[j] > b[i])
        {
            dp[i] = Math.Max(dp[i], dp[j] + 1);
        }
    }
}

Console.WriteLine(dp.Max());
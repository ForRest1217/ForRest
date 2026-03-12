#include <iostream>
using namespace std;

int main()
{
	int a,b,c;
	int d[3] = { 1, 2, 3 };
	int e, f;
	cin >> a;
	for(int i = 0; i < a; i++)
	{
		cin >> b >> c;
		for (int j = 0; j < 3; j++)
		{
			if(d[j] == b)
			{
				e= j;
			}
			else if (d[j] == c)
			{
				f = j;
			}
		}
		int aa = d[e];
		d[e] = d[f];
		d[f] = aa;
	}
	cout << d[0];
}
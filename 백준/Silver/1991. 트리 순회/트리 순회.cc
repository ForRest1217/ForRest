#include <iostream>
#include <map>
using namespace std;

map<char, pair<char, char>> b;

void PreOrder(char node);
void InOrder(char node);
void PostOrder(char node);

int main()
{
    int a;
    cin >> a;

    for (int i = 0; i < a; i++)
    {
        char c, cc, ccc;
        cin >> c >> cc >> ccc;

        b[c] = { cc, ccc };
    }

    PreOrder('A'); cout << '\n';
    InOrder('A'); cout << '\n';
    PostOrder('A'); 

    return 0;
}

void PreOrder(char d)
{
    if (d == '.') 
        return;

    cout << d;
    PreOrder(b[d].first);
    PreOrder(b[d].second);
}

void InOrder(char d)
{
    if (d == '.') 
        return;

    InOrder(b[d].first);
    cout << d;
    InOrder(b[d].second);
}

void PostOrder(char d)
{
    if (d == '.') 
        return;

    PostOrder(b[d].first);
    PostOrder(b[d].second);
    cout << d;
}
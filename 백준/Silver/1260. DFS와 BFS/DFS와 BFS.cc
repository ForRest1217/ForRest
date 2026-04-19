#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>

using namespace std;

int N, M, V;
vector<int> graph[1001];
bool visited[1001];

void dfs(int node) {
    cout << node << " ";
    visited[node] = true;

    for (int i = 0; i < graph[node].size(); i++)
    {
        if (!visited[graph[node][i]])
        {
            dfs(graph[node][i]);
        }
    }
}

void bfs(int start) {
    queue<int> q;
    fill(visited, visited + 1001, false);

    q.push(start);
    visited[start] = true;

    while (!q.empty())
    {
        int x = q.front();
        cout << x << " ";
        q.pop();


        for (int i = 0; i < graph[x].size(); i++)
        {
            if (!visited[graph[x][i]])
            {
                q.push(graph[x][i]);
                visited[graph[x][i]] = true;
            }
        }
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    cin >> N >> M >> V;

    for (int i = 0; i < M; i++) {
        int a, b;
        cin >> a >> b;
        graph[a].push_back(b);
        graph[b].push_back(a);
    }

    for (int i = 1; i <= N; i++) {
        sort(graph[i].begin(), graph[i].end());
    }

    dfs(V);
    cout << "\n";

    fill(visited, visited + 1001, false);
    bfs(V);

    return 0;
}
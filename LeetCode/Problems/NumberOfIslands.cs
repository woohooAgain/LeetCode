public class NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        bool[][] visited = new bool[grid.Length][];
        for (int i = 0; i < grid.Length; i++) visited[i] = new bool[grid[i].Length];

        int ans = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (visited[i][j]) continue;

                if (grid[i][j] == '1') { ans++; VisitAdjacent(i, j); }
            }
        }

        return ans;

        void VisitAdjacent(int row, int col)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length) return;
            if (visited[row][col] || grid[row][col] == '0') return;

            visited[row][col] = true;
            VisitAdjacent(row - 1, col);
            VisitAdjacent(row + 1, col);
            VisitAdjacent(row, col + 1);
            VisitAdjacent(row, col - 1);
        }
    }
}
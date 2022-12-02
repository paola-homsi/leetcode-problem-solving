public class Solution {
    public int NumIslands(char[][] grid) {
        int result = 0;
        
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                if(grid[i][j] == '0') continue;
                
                SinkIsland(grid, i, j);
                
                result++;
            }
        }
        return result;
    }
    
    private void SinkIsland(char[][] grid, int i, int j){
        if(i < 0 || i >= grid.Length || i < 0 || j >= grid[0].Length)
            return;
        
        grid[i][j] = '0';
        
        if(i > 0 && grid[i-1][j] == '1')
            SinkIsland(grid, i-1, j);
        
        if(i < grid.Length-1 && grid[i+1][j] == '1')
            SinkIsland(grid, i+1, j);
        
        if(j > 0 && grid[i][j-1] == '1')
            SinkIsland(grid, i, j-1);
        
        if(j < grid[0].Length-1 && grid[i][j+1] == '1')
            SinkIsland(grid, i, j+1);
        
    }
}
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        
        
        int[][] pascal = new int[rowIndex+1][];
        pascal[0] = new int[] { 1 };
        
        if(rowIndex == 0){
            return pascal[0].ToList();
        }
        
        pascal[1] = new int[] { 1, 1 };
        if(rowIndex == 1){
            return pascal[1].ToList();
        }
        
        for(int i = 2; i <= rowIndex; i++){
            pascal[i] = new int[i+1];
            for(int j = 0; j < i + 1; j++){
                if(j == 0 || j == i){
                    pascal[i][j] = 1;
                }
                else{
                    pascal[i][j] = pascal[i-1][j-1] + pascal[i-1][j];
                }
            }
        }
        return pascal[rowIndex].ToList();
    }
}
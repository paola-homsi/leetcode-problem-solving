public class Solution {
    public int[] CountBits(int n) {
        
        int[] result = new int[n+1];
        
        for(int i = 0; i <= n; i++){
            
            int count = 0;
            int num = i;
            while(num != 0){
                count++;
                num = (int)(num & (num-1));
            }
            result[i] = count;
            
        }
        return result;
    }
}
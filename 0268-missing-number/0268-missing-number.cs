public class Solution {
    public int MissingNumber(int[] nums) {
        int result = 0;
        
        for(int i = 0; i < nums.Length; i++){
            
            result = result ^ nums[i] ^ i;
            
        }
        return result ^ nums.Length;
        
    }
}
public class Solution {
    public int GetSum(int a, int b) {
        
        while(b != 0){
            int result = a ^ b;
            b = (a&b) << 1;
            
            a = result;
        }
        return a;
        
    }
}
public class Solution {
    public int GetSum(int a, int b) {
        int result = 0;
        while(b != 0){
            result = a ^ b;
            b = (a&b) << 1;
            
            a = result;
        }
        return a;
        
    }
}
public class Solution {
    public int HammingWeight(uint n) {
        
        int count = 0;
        
        while(n != 0){
            count++;
            n = (uint)(n & (n-1));
        }
        return count;
    }
}
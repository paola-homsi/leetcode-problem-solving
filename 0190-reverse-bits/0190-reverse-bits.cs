public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;
        
        for(int i = 0; i < 32; i++){
            res = res << 1;
            if((int)(n & 1) == 1) res++;
            n = n>>1;
            
        }
        return res;
    }
}
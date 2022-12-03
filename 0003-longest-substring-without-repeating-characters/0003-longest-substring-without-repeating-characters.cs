public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1)
            return s.Length;
        
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        int left = 0;
        int right = 1;
        map.Add(s[left], 0);
        int max = int.MinValue;
        while(left < s.Length && right < s.Length){
            if(!map.ContainsKey(s[right])){
                map.Add(s[right], right);
            }
            
            else {
                left = Math.Max(left, map[s[right]]+1);
                map[s[right]] = right;
                
            }
            max = Math.Max(max, right-left+1);
            right++;

        }
        return max;
    }
}
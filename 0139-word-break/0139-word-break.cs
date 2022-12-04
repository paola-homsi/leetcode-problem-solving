public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        
        bool[] dp  = new bool[s.Length+1];
        
        HashSet<string> map = new HashSet<string>();
        foreach(string str in wordDict){
            map.Add(str);
        }
        
        dp[0] = true;
        for(int i = 0; i <= s.Length; i++){
            for(int j = 0; j < i; j++){
                if(dp[j] && map.Contains(s.Substring(j, i-j))){
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[dp.Length-1];
        
    }
}
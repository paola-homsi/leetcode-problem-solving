public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> numbers = new HashSet<int>();
        HashSet<int> seen = new HashSet<int>();
        int maxSize = 0;
        
        foreach(int n in nums){
            if(numbers.Contains(n)) continue;
            numbers.Add(n);
        }
        
        for(int i = 0; i < nums.Length; i++){
            int size = 0;
            if(seen.Contains(nums[i])){
                maxSize = Math.Max(maxSize, size+1);
            } else{
                seen.Add(nums[i]);
                
                int next = nums[i]+1;
                while(numbers.Contains(next)){
                    size++;
                    if(!seen.Contains(next))
                        seen.Add(next);
                    next++;
                }
                maxSize = Math.Max(maxSize, size+1);
            }
            
        }
        return maxSize;
    }
}
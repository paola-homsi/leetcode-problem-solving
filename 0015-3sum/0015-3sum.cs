public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        List<IList<int>> result = new List<IList<int>>();
        HashSet<string> seen = new HashSet<string>();
        
        if(nums == null || nums.Length < 3)
            return result;
        
        Array.Sort(nums); //O(n log (n) ))
        
        for(int   i = 0; i < nums.Length-2; i++){            
            int left = i+1;
            int right = nums.Length-1;
            int sum = 0;
            
            while(left < right){
                sum = nums[i] + nums[left] + nums[right];
                if(sum == 0){
                    if(!seen.Contains(nums[i] +""+ nums[left]+""+ nums[right])){
                        seen.Add(nums[i] +""+ nums[left]+""+ nums[right]);
                        result.Add(new List<int> (){ nums[i], nums[left], nums[right]});
                    }
                    
                    left++;
                    right--;
                }
                
                else if(sum < 0)
                    left++;
                
                else
                    right--;
                
            }
        }
        return result;
    }
}
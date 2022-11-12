public class Solution {
    public int FindMin(int[] nums) {
        if(nums == null || nums.Length == 0)
            return -1;
        
        if(nums.Length == 1)
            return nums[0];

        int left = 0;
        int right = nums.Length-1;
        
        while(left < right){
            int mid = left + ((right - left) /2);
            if(mid > 0 && nums[mid] < nums[mid-1])
                return nums[mid];
            
            if(nums[mid] >= nums[left] && nums[mid] > nums[right]){
                left = mid+1;
                
            }
            else  {
                 right= mid-1;
            }
        }
        
        return nums[left];
    }
}
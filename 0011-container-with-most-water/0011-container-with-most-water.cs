public class Solution {
    public int MaxArea(int[] height) {
        int max = int.MinValue;
        
        if(height.Length < 1){
            return 0;
        }
        
        int left = 0;
        int right = height.Length -1;
        int size = 0;
        while(left < right){
            size = (right - left) * Math.Min(height[left], height[right]);
            max = Math.Max(max, size);
            
            if(height[left] < height[right]){
                left++;
            }
            else {
                right--;
            }
        }
        return max;
    }
}
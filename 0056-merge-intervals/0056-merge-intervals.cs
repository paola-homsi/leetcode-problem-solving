public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        if(intervals.Length <= 1){
            return intervals;
        }
         Array.Sort(intervals, (x, y) => x[0] - y[0]);
        List<int[]> result = new List<int[]>();
        
        int left = 0;
        int right = 1;
        
        int index = 0;
        while(left < intervals.Length){
            
            if(right < intervals.Length && IsIntersected(intervals[left], intervals[right])){
                intervals[left][0] = Math.Min(intervals[left][0], intervals[right][0]);
                intervals[left][1] = Math.Max(intervals[left][1], intervals[right][1]);
                right++;
            }
            else{
                result.Add(intervals[left]);
                left = right;
                right++;
            }
            
        }
        return result.ToArray();
    }
    
    private bool IsIntersected(int[] p, int[] q){
        return (p[0] <= q[1] && p[1] >= q[0] ) ;
    }
}
public class Solution {
    public bool CanFinish(int numCourses, int[][] p) {
        Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
        
        for(int i = 0; i < p.Length; i++){
            if(!map.ContainsKey(p[i][0])){
                map.Add(p[i][0], new HashSet<int> (){ p[i][1] });
            }
            else{
                map[p[i][0]].Add(p[i][1]);
            }
        }
        
        int[] visited = new int[numCourses];
        int[] dfsVisited = new int[numCourses];
        
        foreach(KeyValuePair<int, HashSet<int>> pair in map){
            
            bool cyclic = isCyclic(map, pair.Key, visited, dfsVisited);
            if(cyclic) return false;
            
        }
        return true;
    }
    
    private bool isCyclic(Dictionary<int, HashSet<int>> map, int val, int[] visited, int[] dfsVisited){
        
        visited[val] = 1;
        dfsVisited[val] = 1;
        
        foreach(int n in map[val]){
            if(visited[n] == 0 && map.ContainsKey(n)){
                bool cyclic = isCyclic(map, n, visited, dfsVisited);
                if(cyclic) return true;
            }
            else{
                if(dfsVisited[n] == 1)
                    return true;
            }
        }
        dfsVisited[val] = 0;
        return false;
    }
    
}
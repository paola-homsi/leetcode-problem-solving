public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> map = new HashSet<string>();
        
        foreach(string s in wordList){
            map.Add(s);
        }
        
        if(!map.Contains(endWord) || beginWord == endWord)
            return 0;
        
        Dictionary<string, List<string>> dict = preprocessing(map);
        HashSet<string> visited = new HashSet<string>();
        
        Queue<string> queue = new Queue<string>();
        
        queue.Enqueue(beginWord);
        visited.Add(beginWord);
        
        int level = 1;
        
        while(queue.Count() > 0){
            
            int size = queue.Count();
            while(size-- > 0){
                string cWord = queue.Dequeue();
                if(cWord == endWord){
                    return level++;
                }
                for(int i = 0; i < cWord.Length; i++){
                    string newS = cWord.Substring(0,i) + "*" + cWord.Substring(i+1);
                    if(dict.ContainsKey(newS)){
                        foreach(string s in dict[newS]){
                            
                            if(!visited.Contains(s)){
                                 visited.Add(s);
                                queue.Enqueue(s);
                            }
                               
                        }
                    }
                }
            }
            level++;
            
        }
        return 0;
    }
    
    private Dictionary<string, List<string>> preprocessing(HashSet<string> wordList){
        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
        
        foreach(string s in wordList){
            for(int i = 0; i < s.Length; i++){
                
                string newS = s.Substring(0,i) + "*" + s.Substring(i+1);
                
                if(!data.ContainsKey(newS)){
                    data.Add(newS, new List<string>(){ s });
                }
                else{
                    data[newS].Add(s);
                }
                
            }
        }
        
        return data;
    }
}
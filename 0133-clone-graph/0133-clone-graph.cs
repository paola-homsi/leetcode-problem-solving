/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null)
            return null;
        Node newNode = new Node(node.val);
        dfs(node, newNode, new Dictionary<int, Node>());
        return newNode;
    }
    
    private void dfs(Node node, Node copy, Dictionary<int, Node> map){
        
        map.Add(copy.val, copy);
        
        foreach(Node n in node.neighbors){
            
            if(map.ContainsKey(n.val)){
                copy.neighbors.Add(map[n.val]);
            }
            else{
                Node c = new Node(n.val);
                copy.neighbors.Add(c);
                dfs(n,c, map);
            }
            
        }
        
    }
}
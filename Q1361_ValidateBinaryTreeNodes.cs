public class Solution {
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild) {
        int[] ind = new int[n];
        for(int i=0; i<n; i++){
            int l = leftChild[i], r = rightChild[i]; 
            
            if(l > -1) ind[l] ++;
            if(r > -1) ind[r] ++; 
            
            if(l > -1 && ind[l] > 1 || r > -1 && ind[r] > 1) return false;
        }
                
        if(ind.Count(i=> i== 0) !=1) return false;
             
        int root = Array.IndexOf(ind, 0);  
        int cnt = dfsCount(root); 
        return cnt == n;        
        
        int dfsCount(int i)
        {
            if(i == -1) return 0; 
            return 1 + dfsCount(leftChild[i]) + dfsCount(rightChild[i]);
        }
    }
}

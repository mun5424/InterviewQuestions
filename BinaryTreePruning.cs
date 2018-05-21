
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class BinaryTreePruning {
    //given a binary tree of root n, prune the binary tree so that all subtrees containing a value of 0 are removed.

    public TreeNode PruneTree(TreeNode root) {
        if(root == null)
            return root; 
        
        TreeNode left = root.left != null ? PruneTree(root.left) : null;
        TreeNode right = root.right != null ? PruneTree(root.right) : null;

        if(root.val == 0 && left ==null & right ==null)
            return null;
        else
        {
            root.left = left;
            root.right = right; 
            return root; 

        }
    }
}
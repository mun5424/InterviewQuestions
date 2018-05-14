using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class LeastCommonAncestor
    {
        //Problem. Find a common ancestor between two nodes in a Binary Tree. NOT A BST (makes the problem trivial)
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; } 
        }

        public static TreeNode commonAncestor(TreeNode root, int p, int q)
        {
            if (root == null)
                return null;

            if (root.val == p || root.val == q)
            {
                return root;
            }
            TreeNode left = commonAncestor(root.left, p, q);
            TreeNode right = commonAncestor(root.right, p, q);

            if (left != null && right != null)
                return root;

            return left == null ? right : left; 
 
        }

        public static void test()
        {

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);
            tree.right.left = new TreeNode(6);
            tree.right.right = new TreeNode(7);
            Console.WriteLine("LCA(4, 5) = " +
                                commonAncestor(tree ,4, 5).val);
            Console.WriteLine("LCA(4, 6) = " +
                                commonAncestor(tree, 4, 6).val);
            Console.WriteLine("LCA(3, 4) = " +
                                commonAncestor(tree, 3, 4).val);
            Console.WriteLine("LCA(2, 4) = " +
                                commonAncestor(tree, 2, 4).val);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class TreeNode
    {
        public int val; 
        public TreeNode left;
        public TreeNode right; 
    }
    class InvertBinaryTree
    {
        public static TreeNode invertBinaryTree(TreeNode root)
        {
            //given a binary tree, 
            if(root != null)
            {// use a helper function to recursively invert from root
                recurseInvert(root); 
            }
            return root; 
        }

        public static void recurseInvert(TreeNode p)
        {
            //swap a treenodes left and right children to invert
            TreeNode temp = p.left;
            TreeNode right = p.left;
            TreeNode left = p.right; 

            //recurse to the next child  if the given node has any. 
            if(p.left != null)
                recurseInvert(p.left);
            if(p.right != null)
                recurseInvert(p.right); 
        }
    }
}

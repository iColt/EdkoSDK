using EdkoSKD.Common.Models;

namespace EdkoSKD.Common.Trees;

public static class TreeHelpers
{
    public static bool AreEqualTrees(TreeNode a, TreeNode b)
    {
        if (a == null && b == null) return true;
        if (a == null || b == null) return false;
        if (a.val != b.val) return false;

        return AreEqualTrees(a.left, b.left) && AreEqualTrees(a.right, b.right);
    }

    public static TreeNode Tree(int?[] values)
    {
        if (values == null || values.Length == 0 || values[0] == null)
            return null;

        TreeNode root = new TreeNode(values[0].Value);
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        int i = 1;
        while (i < values.Length)
        {
            var node = q.Dequeue();

            if (values[i] != null)
            {
                node.left = new TreeNode(values[i].Value);
                q.Enqueue(node.left);
            }
            i++;

            if (i < values.Length && values[i] != null)
            {
                node.right = new TreeNode(values[i].Value);
                q.Enqueue(node.right);
            }
            i++;
        }

        return root;
    }

    #region Tilt tree based on Binary tree

    public static TreeNode BuildTiltTree(this TreeNode binaryTree)
    {
        ArgumentNullException.ThrowIfNull(binaryTree);

        TreeNode root = new(0);

        BuildTiltTreeInternal(binaryTree, root);

        return root;
    }

    private static int BuildTiltTreeInternal(TreeNode binaryTreeNode, TreeNode tiltTreeNode)
    {
        if(binaryTreeNode == null)
        {
            return 0;
        }

        if(binaryTreeNode.left == null && binaryTreeNode.right == null)
        {
            tiltTreeNode.val = 0;
            return binaryTreeNode.val;
        }

        int leftSum = 0;
        if(binaryTreeNode.left != null)
        {
            tiltTreeNode.left = new TreeNode(0);
            leftSum = BuildTiltTreeInternal(binaryTreeNode.left, tiltTreeNode.left);
        }

        int rightSum = 0;
        if(binaryTreeNode.right != null)
        {
            tiltTreeNode.right = new TreeNode(0);
            rightSum = BuildTiltTreeInternal(binaryTreeNode.right, tiltTreeNode.right);
        }

        tiltTreeNode.val = Math.Abs(leftSum - rightSum);

        return leftSum + rightSum + binaryTreeNode.val;
    }

    #endregion

    #region Tree node sum

    public static int FindBinaryTreeNodeSum(this TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.val + FindBinaryTreeNodeSum(node.left) + FindBinaryTreeNodeSum(node.right);
    }

    #endregion

    #region Serialize Tree

    public static string SerializeTree(this TreeNode node)
    {
        if (node == null)
            return "#";

        return $"{node.val},{SerializeTree(node.left)},{SerializeTree(node.right)}";
    }


    #endregion
}

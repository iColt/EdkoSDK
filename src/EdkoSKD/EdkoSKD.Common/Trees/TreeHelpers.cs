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
}

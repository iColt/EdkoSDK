using EdkoSKD.Common.Models;
using System.Text;

namespace EdkoSKD.Common.Trees;

public class TreeSerializator
{
    public static string Serialize(TreeNode root)
    {
        var sb = new StringBuilder();
        SerializeInternal(root, sb);
        return sb.ToString();
    }

    private static void SerializeInternal(TreeNode node, StringBuilder sb)
    {
        if (node == null)
        {
            sb.Append("#,");
            return;
        }

        sb.Append(node.val).Append(',');
        SerializeInternal(node.left, sb);
        SerializeInternal(node.right, sb);
    }

    public static TreeNode? Deserialize(string data)
    {
        if (string.IsNullOrEmpty(data) || data == "#")
            return null;

        var values = data.Split(',');
        int index = 0;

        TreeNode? DeserializeInternal()
        {
            if (index >= values.Length)
            {
                return null;
            }

            string token = values[index++];

            if (token == "#")
            {
                return null;
            }

            var node = new TreeNode(int.Parse(token))
            {
                left = DeserializeInternal(),
                right = DeserializeInternal()
            };

            return node;
        }

        return DeserializeInternal();
    }
}

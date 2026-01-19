using EdkoSKD.Common.Models;

namespace EdkoSKD.Common.Trees;

public class TreeSerializator
{
    public static string Serialize(TreeNode node)
    {
        if (node == null)
            return "#";
        return $"{node.val},{Serialize(node.left)},{Serialize(node.right)}";
    }

    public static TreeNode? Deserialize(string data)
    {
        if(data == null)
        {
            return null;
        }

        int pointer = 0;

        if(data.Length == 0 || data.Equals("#"))
        {
            return null;
        }

        var valueArr = data.Split(',');

        TreeNode? PreOrderConstruct()
        {
            if(pointer >=  valueArr.Length)
            {
                return null;
            }
            if (valueArr[pointer].Equals("#"))
            {
                return null;
            }

            var newNode = new TreeNode(int.Parse(valueArr[pointer++]))
            {
                left = PreOrderConstruct()
            };
            pointer++;
            newNode.right = PreOrderConstruct();

            return newNode;
        }

        return PreOrderConstruct();
    }
}

using EdkoSKD.Common.Models;
using EdkoSKD.Common.Trees;

namespace EdkoSDK.Common.Tests.Trees;

[TestFixture]
public class TreeHelpersFixture
{
    [Test]
    public void Test_BuildTiltTree()
    {
        var initialTree =
            new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(3),
                    new TreeNode(5)
                ),
                new TreeNode(9,
                    null,
                    new TreeNode(7)
                ));

        var expectedTree = new TreeNode(6,
                new TreeNode(2,
                    new TreeNode(0),
                    new TreeNode(0)
                ),
                new TreeNode(7,
                    null,
                    new TreeNode(0)
                ));

        var resultTiltTree = initialTree.BuildTiltTree();

        Assert.That(TreeHelpers.AreEqualTrees(resultTiltTree, expectedTree), Is.True);
    }
}

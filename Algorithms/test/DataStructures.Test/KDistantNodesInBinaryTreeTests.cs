namespace DataStructures.Test
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class KDistantNodesInBinaryTreeTests
    {
        [Fact]
        public void DistanceK_ShouldReturn_NodesAtDistanceK()
        {
            // Arrange
            var distantNodes = new KDistantNodesInBinaryTree();

            var root = new TreeNode(3);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(1);

            root.Left.Left = new TreeNode(6);
            root.Left.Right = new TreeNode(2);
            root.Left.Right.Left = new TreeNode(7);
            root.Left.Right.Right = new TreeNode(4);

            root.Right.Left = new TreeNode(0);
            root.Right.Right = new TreeNode(8);

            var target = root.Left;
            var k = 2;

            // Act
            var result = distantNodes.DistanceK(root, target, k);

            // Assert
            result.Should().BeEquivalentTo(new List<int> { 7, 4, 1 });
        }
    }
}

namespace DataStructures.Test
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class BinaryTreeTraversalTests
    {
        [Fact]
        public void DepthTraversal_ShouldReturn_TraversedNodes_InDepthOrder()
        {
            // Arrange
            var root = new BinaryTree(1);
            root.AddLeft(new BinaryTree(2));
            root.AddRight(new BinaryTree(3));

            root.Left.AddLeft(new BinaryTree(4));
            root.Left.AddRight(new BinaryTree(5));

            root.Right.AddLeft(new BinaryTree(6));
            root.Right.AddRight(new BinaryTree(7));

            root.Left.Left.AddLeft(new BinaryTree(8));
            root.Left.Left.AddRight(new BinaryTree(9));

            var expectedTraversed = new List<int> { 1, 2, 4, 8, 9, 5, 3, 6, 7 };

            var treeTraversal = new BinaryTreeTraversal();

            // Act
            var traversed = treeTraversal.DepthTraversal(root);

            // Assert
            traversed.Should().BeEquivalentTo(expectedTraversed);
        }

        [Fact]
        public void BreadthTraversal_ShouldReturn_TraversedNodes_InLevelOrder()
        {
            // Arrange
            var root = new BinaryTree(1);
            root.AddLeft(new BinaryTree(2));
            root.AddRight(new BinaryTree(3));

            root.Left.AddLeft(new BinaryTree(4));
            root.Left.AddRight(new BinaryTree(5));

            root.Right.AddLeft(new BinaryTree(6));
            root.Right.AddRight(new BinaryTree(7));

            root.Left.Left.AddLeft(new BinaryTree(8));
            root.Left.Left.AddRight(new BinaryTree(9));

            var expectedTraversed = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var treeTraversal = new BinaryTreeTraversal();

            // Act
            var traversed = treeTraversal.BreadthTraversal(root);

            // Assert
            traversed.Should().BeEquivalentTo(expectedTraversed);
        }
    }
}

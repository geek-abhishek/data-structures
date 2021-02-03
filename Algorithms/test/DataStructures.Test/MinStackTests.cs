namespace DataStructures.Test
{
    using FluentAssertions;
    using Xunit;

    public class MinStackTests
    {
        [Fact]
        public void MinStack_ShouldSupport_Push_Pop_Top_MinStack_Operations()
        {
            // Arrange
            var minStack = new MinStack();

            // Act and Assert
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            var minimumElement = minStack.GetMin();
            minimumElement.Should().Be(-3);

            minStack.Pop();
            
            var top = minStack.Top();
            top.Should().Be(0);

            minimumElement = minStack.GetMin();
            minimumElement.Should().Be(-2);
        }
    }
}

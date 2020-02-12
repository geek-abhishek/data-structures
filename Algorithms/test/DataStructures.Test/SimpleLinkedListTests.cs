namespace DataStructures.Test
{
    using FluentAssertions;
    using System.Linq;
    using Xunit;

    public class SimpleLinkedListTests
    {
        [Theory]
        [InlineData(new int[] { 5, 8, 3, 4, 6, 1, 7, 2 })]
        public void AddAfter_ShouldAddElements_AtTheEndOfLinkedList(int[] numbers)
        {
            // Arrange
            var linkedList = new SimpleLinkedList(numbers[0]);

            // Act
            for (var i = 1; i < numbers.Length; i++)
            {
                linkedList.AddAfter(numbers[i]);
            }

            var linkedListElements = linkedList.GetElements();

            // Assert
            linkedListElements.ToArray().Should().BeEquivalentTo(numbers);
        }

        [Theory]
        [InlineData(new int[] { 5, 8, 3, 4, 6, 1, 7, 2 })]
        public void AddBefore_ShouldAddElements_AtTheBeginingOfLinkedList(int[] numbers)
        {
            // Arrange
            var linkedList = new SimpleLinkedList(numbers[0]);
            var reverseNumbers = numbers.Reverse();

            // Act
            for (var i = 1; i < numbers.Length; i++)
            {
                linkedList.AddBefore(numbers[i]);
            }

            var linkedListElements = linkedList.GetElements();

            // Assert
            linkedListElements.ToArray().Should().BeEquivalentTo(reverseNumbers);
        }

        [Theory]
        [InlineData(new int[] { 5, 8, 3, 4, 6, 1, 7, 2 })]
        public void Reverse_ShouldReverse_TheElementsInLinkedList(int[] numbers)
        {
            // Arrange
            var linkedList = new SimpleLinkedList(numbers[0]);
            var reverseNumbers = numbers.Reverse();

            // Act
            for (var i = 1; i < numbers.Length; i++)
            {
                linkedList.AddAfter(numbers[i]);
            }

            linkedList.Reverse();
            var linkedListElements = linkedList.GetElements();

            // Assert
            linkedListElements.ToArray().Should().BeEquivalentTo(reverseNumbers);
        }
    }
}

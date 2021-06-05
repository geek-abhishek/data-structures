namespace DataStructures.Test
{
    using FluentAssertions;
    using Xunit;

    public class HashedQueueTests
    {
        [Fact]
        public void AddRemoveAndReplace_FromQueue_ShouldAddRemoveAndReplace_InFIFO()
        {
            // Arrange
            var queue = new HashedQueue();

            // Act and Assert
            queue.Add(1, "One");
            queue.Add(2, "Two");
            queue.Add(3, "Three");
            queue.Add(4, "Four");
            queue.Add(5, "Five");
            queue.Add(6, "Six");
            queue.Add(7, "Seven");

            var (id, value) = queue.Remove();
            id.Should().Be(1);
            value.Should().Be("One");

            (id, value) = queue.Remove();
            id.Should().Be(2);
            value.Should().Be("Two");

            queue.Replace(4, "IV");

            (id, value) = queue.Remove();
            id.Should().Be(3);
            value.Should().Be("Three");

            (id, value) = queue.Remove();
            id.Should().Be(4);
            value.Should().Be("IV");
        }
    }
}

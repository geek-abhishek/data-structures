namespace DataStructures.Test
{
    using FluentAssertions;
    using Xunit;

    public class LinkedListAdderTests
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 8, 0, 7 })]
        [InlineData(new int[] { 9, 9, 9 }, new int[] { 8, 7 }, new int[] { 1, 0, 8, 6 })]
        [InlineData(new int[] { 2, 4, 9 }, new int[] { 5, 6, 4, 9 }, new int[] { 5, 8, 9, 8 })]
        [InlineData(new int[] { 9 }, new int[] { 9, 9, 9, 9, 9, 1 }, new int[] { 1, 0, 0, 0, 0, 0, 0 })]
        public void GetSum_ShouldReturn_SumOfTwoLists_InReverse(
            int[] l1Array, int[] l2Array, int[] expectedResultArray)
        {
            // Arrange
            var l1 = GetListNode(l1Array);
            var l2 = GetListNode(l2Array);
            var expectedResult = GetListNode(expectedResultArray);

            var linkedListAdder = new LinkedListAdder();

            // Act
            var result = linkedListAdder.GetSum(l1, l2);

            // Assert
            IsEquivalent(result, expectedResult).Should().BeTrue();
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 9, 9, 9 }, new int[] { 8, 7 }, new int[] { 7, 7, 0, 1 })]
        [InlineData(new int[] { 2, 4, 9 }, new int[] { 5, 6, 4, 9 }, new int[] { 7, 0, 4, 0, 1 })]
        public void GetReversedSum_ShouldReturn_SumOfTwoLists_InReverse(
            int[] l1Array, int[] l2Array, int[] expectedResultArray)
        {
            // Arrange
            var l1 = GetListNode(l1Array);
            var l2 = GetListNode(l2Array);
            var expectedResult = GetListNode(expectedResultArray);

            var linkedListAdder = new LinkedListAdder();

            // Act
            var result = linkedListAdder.GetReversedSum(l1, l2);

            // Assert
            IsEquivalent(result, expectedResult).Should().BeTrue();
        }

        private ListNode GetListNode(int[] numbers)
        {
            var list = new ListNode(numbers[0]);
            var listHead = list;

            for (var i = 1; i < numbers.Length; i++)
            {
                list.next = new ListNode(numbers[i]);
                list = list.next;
            }

            return listHead;
        }

        private bool IsEquivalent(ListNode l1, ListNode l2)
        {
            while(l1 != null || l2 != null)
            {
                if ((l1 == null && l2 != null) || (l1 != null && l2 == null))
                {
                    return false;
                }

                if (l1.val.Equals(l2.val) == false)
                {
                    return false;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            return true;
        }
    }
}

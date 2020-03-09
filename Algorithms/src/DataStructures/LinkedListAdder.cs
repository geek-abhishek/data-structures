namespace DataStructures
{
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    public class LinkedListAdder
    {
        public ListNode GetSum(ListNode l1, ListNode l2)
        {
            long multiplier = 1;
            long firstNumber = 0;

            while (l1 != null)
            {
                firstNumber += l1.val * multiplier;
                multiplier *= 10;

                l1 = l1.next;
            }

            multiplier = 1;
            long secondNumber = 0;

            while (l2 != null)
            {
                secondNumber += l2.val * multiplier;
                multiplier *= 10;

                l2 = l2.next;
            }

            var sum = firstNumber + secondNumber;

            var lastDigit = sum % 10;
            sum = sum / 10;

            var result = new ListNode((int)lastDigit);
            var resultHead = result;

            for (var i = sum; i > 0; i = i / 10)
            {
                lastDigit = i % 10;
                result.next = new ListNode((int)lastDigit);
                result = result.next;
            }

            result.next = null;
            return resultHead;
        }
    }
}

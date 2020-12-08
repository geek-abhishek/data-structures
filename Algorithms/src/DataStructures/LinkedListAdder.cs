namespace DataStructures
{
    using System.Collections.Generic;

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class LinkedListAdder
    {
        /// <summary>
        /// Function to return the sum of two numbers.
        /// Example:
        ///    9  9  9
        ///       8  7
        /// ----------
        /// 1  0  8  6
        /// </summary>
        /// <param name="l1">Represents the first number.</param>
        /// <param name="l2">Represents the second number.</param>
        /// <returns>Sum of the two numbers.</returns>
        public ListNode GetSum(ListNode l1, ListNode l2)
        {
            var l1List = this.GetList(l1);
            var l2List = this.GetList(l2);

            var shorterList = this.GetShorterList(l1List, l2List);
            var longerList = this.GetLongerList(l1List, l2List);
            var adjustedList = this.GetAdjustedList(shorterList, longerList, true);

            var sum = new List<int>();
            var carry = new List<int>();
            var incrementalIndex = 0;
            for (int i = longerList.Count - 1; i >= 0; i--)
            {
                var result = longerList[i] + adjustedList[i];
                result = incrementalIndex > 0 ? result + carry[incrementalIndex - 1] : result;

                sum.Add(result % 10);
                carry.Add(result / 10);

                incrementalIndex++;
            }

            if (carry[^1] > 0)
            {
                sum.Add(carry[^1]);
            }

            return this.GetListNode(sum, true);
        }

        /// <summary>
        /// Function to return the sum of two numbers from the start.
        /// Example:
        /// 9  9  9
        /// 8  7
        /// ----------
        /// 7  7  0  1
        /// </summary>
        /// <param name="l1">Represents the first number.</param>
        /// <param name="l2">Represents the second number.</param>
        /// <returns>Sum of the two numbers.</returns>
        public ListNode GetReversedSum(ListNode l1, ListNode l2)
        {
            var l1List = this.GetList(l1);
            var l2List = this.GetList(l2);

            var shorterList = this.GetShorterList(l1List, l2List);
            var longerList = this.GetLongerList(l1List, l2List);
            var adjustedList = this.GetAdjustedList(shorterList, longerList, false);

            var sum = new List<int>();
            var carry = new List<int>();
            for (int i = 0; i < longerList.Count; i++)
            {
                var result = longerList[i] + adjustedList[i];
                result = i > 0 ? result + carry[i - 1] : result;

                sum.Add(result % 10);
                carry.Add(result / 10);
            }

            if (carry[^1] > 0)
            {
                sum.Add(carry[^1]);
            }

            return this.GetListNode(sum, false);
        }

        private List<int> GetList(ListNode listNode)
        {
            var list = new List<int>();
            while (listNode != null)
            {
                list.Add(listNode.val);
                listNode = listNode.next;
            }

            return list;
        }

        private List<int> GetShorterList(List<int> list1, List<int> list2)
        {
            return list1.Count < list2.Count ? list1 : list2;
        }

        private List<int> GetLongerList(List<int> list1, List<int> list2)
        {
            return list1.Count >= list2.Count ? list1 : list2;
        }

        private List<int> GetAdjustedList(
            List<int> shorterList,
            List<int> longerList,
            bool adjustAtTheBegining)
        {
            var difference = longerList.Count - shorterList.Count;
            var adjustedList = new List<int>();

            if (adjustAtTheBegining)
            {
                for (int i = 0; i < difference; i++)
                {
                    adjustedList.Add(0);
                }

                adjustedList.AddRange(shorterList);
                return adjustedList;
            }

            adjustedList.AddRange(shorterList);
            for (int i = 0; i < difference; i++)
            {
                adjustedList.Add(0);
            }

            return adjustedList;
        }

        private ListNode GetListNode(List<int> list, bool shouldRevere)
        {
            ListNode resultNode = null;
            ListNode resultHeadNode = null;

            if (shouldRevere)
            {
                resultNode = new ListNode(list[^1]);
                resultHeadNode = resultNode;
                for (int i = list.Count - 2; i >= 0; i--)
                {
                    resultNode.next = new ListNode(list[i]);
                    resultNode = resultNode.next;
                }

                return resultHeadNode;
            }

            resultNode = new ListNode(list[0]);
            resultHeadNode = resultNode;
            for (int i = 1; i < list.Count; i++)
            {
                resultNode.next = new ListNode(list[i]);
                resultNode = resultNode.next;
            }

            return resultHeadNode;
        }
    }
}

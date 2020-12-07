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
        public ListNode GetSum(ListNode l1, ListNode l2)
        {
            var l1List = this.GetList(l1);
            var l2List = this.GetList(l2);

            var shorterList = this.GetShorterList(l1List, l2List);
            var longerList = this.GetLongerList(l1List, l2List);
            var adjustedList = this.GetAdjustedList(shorterList, longerList);

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

            return this.GetListNodeReversed(sum);
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

        private List<int> GetAdjustedList(List<int> shorterList, List<int> longerList)
        {
            var difference = longerList.Count - shorterList.Count;
            var adjustedList = new List<int>();

            for (int i = 0; i < difference; i++)
            {
                adjustedList.Add(0);
            }

            adjustedList.AddRange(shorterList);
            return adjustedList;
        }

        private ListNode GetListNodeReversed(List<int> list)
        {
            var resultNode = new ListNode(list[^1]);
            var resultHeadNode = resultNode;
            for (int i = list.Count - 2; i >= 0; i--)
            {
                resultNode.next = new ListNode(list[i]);
                resultNode = resultNode.next;
            }

            return resultHeadNode;
        }
    }
}

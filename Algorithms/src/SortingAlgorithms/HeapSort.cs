namespace SortingAlgorithms
{
    public class HeapSort : ISort
    {
        public int[] ArrangeInAscending(int[] numbers)
        {
            var maxHeapOfNumbers = GetMaxHeap(numbers);
            var sortedElements = GetAscendingArrangedElements(maxHeapOfNumbers);

            return maxHeapOfNumbers;
        }

        private int[] GetMaxHeap(int[] numbers)
        {
            var maxHeap = new int[numbers.Length + 1];
            maxHeap[0] = 0;
            maxHeap[1] = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                maxHeap[i + 1] = numbers[i];
                ArrangeMaxHeapFromLeaves(maxHeap, i + 1);
            }

            return maxHeap;
        }

        private int[] GetAscendingArrangedElements(int[] maxHeap)
        {
            for (int i = 1; i < maxHeap.Length; i++)
            {
                SwapElements(maxHeap, 1, maxHeap.Length - i);
                ArrangeMaxHeapFromRoot(maxHeap, 1, maxHeap.Length - i - 1);
            }

            return maxHeap;
        }

        private int[] ArrangeMaxHeapFromLeaves(int[] maxHeap, int lastArragedIndex)
        {
            if (lastArragedIndex.Equals(1))
            {
                return maxHeap;
            }

            if (maxHeap[lastArragedIndex] > maxHeap[lastArragedIndex / 2])
            {
                SwapElements(maxHeap, lastArragedIndex, lastArragedIndex / 2);
                ArrangeMaxHeapFromLeaves(maxHeap, lastArragedIndex / 2);
            }

            return maxHeap;
        }

        private int[] ArrangeMaxHeapFromRoot(int[] maxHeap, int startIndex, int lastIndex)
        {
            if (startIndex * 2 > lastIndex)
            {
                return maxHeap;
            }

            int maxChildIndex;
            if ((startIndex * 2).Equals(lastIndex))
            {
                maxChildIndex = startIndex * 2;
            }
            else
            {
                maxChildIndex = maxHeap[startIndex * 2] > maxHeap[(startIndex * 2) + 1]
                    ? startIndex * 2
                    : (startIndex * 2) + 1;
            }

            if (maxHeap[startIndex] < maxHeap[maxChildIndex])
            {
                SwapElements(maxHeap, startIndex, maxChildIndex);
                ArrangeMaxHeapFromRoot(maxHeap, maxChildIndex, lastIndex);
            }

            return maxHeap;
        }

        private void SwapElements(int[] maxHeap, int leftIndex, int rightIndex)
        {
            var temp = maxHeap[leftIndex];
            maxHeap[leftIndex] = maxHeap[rightIndex];
            maxHeap[rightIndex] = temp;
        }
    }
}

namespace DataStructures
{
    using System.Collections.Generic;

    public class ArrayPartitioner
    {
        public bool CanBePartitioned(int[] A)
        {
            if (A == null || A.Length < 3)
            {
                return false;
            }

            var forwardSum = new int[A.Length];
            forwardSum[0] = A[0];
            for (var i = 1; i < A.Length; i++)
            {
                forwardSum[i] = A[i] + forwardSum[i - 1];
            }

            var reverseSum = new int[A.Length];
            reverseSum[A.Length - 1] = A[A.Length - 1];
            for (var i = A.Length - 2; i >= 0; i--)
            {
                reverseSum[i] = A[i] + reverseSum[i + 1];
            }

            var firstPartitionIndex = 0;
            var firstPartitionSum = 0;

            while (firstPartitionIndex < A.Length - 2)
            {
                firstPartitionSum += A[firstPartitionIndex];

                var secondPartitionIndex = firstPartitionIndex + 1;
                var secondPartitionSum = 0;

                while (secondPartitionIndex < A.Length - 1)
                {
                    secondPartitionSum += A[secondPartitionIndex];
                    secondPartitionIndex++;

                    if (secondPartitionSum.Equals(firstPartitionSum))
                    {
                        break;
                    }
                }

                if (firstPartitionSum.Equals(secondPartitionSum) == false)
                {
                    firstPartitionIndex++;
                    continue;
                }

                if (reverseSum[secondPartitionIndex].Equals(secondPartitionSum))
                {
                    return true;
                }

                firstPartitionIndex++;
            }

            return false;
        }

        private List<int> Find(int[] values, int startPosition, int key)
        {
            var indexes = new List<int>();

            for (var i = startPosition; i < values.Length; i++)
            {
                if (key.Equals(values[i]))
                {
                    indexes.Add(i);
                }
            }

            return indexes;
        }

        private int GetSum(int[] values, int startPosition, int endPosition)
        {
            var sum = values[startPosition];

            for (var i = startPosition + 1; i < endPosition; i++)
            {
                sum += values[i];
            }

            return sum;
        }
    }
}

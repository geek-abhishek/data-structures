namespace DataStructures
{
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

            for (var i = 0; i < A.Length - 2; i++)
            {
                var matchedIndex = Find(reverseSum, i + 2, forwardSum[i]);

                if (matchedIndex.Equals(-1))
                {
                    continue;
                }

                if (forwardSum[i].Equals(
                    forwardSum[matchedIndex - 1] - forwardSum[i]))
                {
                    return true;
                }
            }

            return false;
        }

        private int Find(int[] values, int startPosition, int key)
        {
            for (var i = startPosition; i < values.Length; i++)
            {
                if (key.Equals(values[i]))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

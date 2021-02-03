namespace DataStructures
{
    using System.Collections.Generic;

    public class MinStack
    {
        private readonly List<int> stack = null;
        private int top = -1;

        public MinStack()
        {
            this.stack = new List<int>();
        }

        public void Push(int x)
        {
            this.stack.Add(x);
            this.top++;
        }

        public void Pop()
        {
            if (this.stack.Count == 0)
            {
                return;
            }

            this.stack.RemoveAt(this.top);
            this.top--;
        }

        public int Top()
        {
            if (this.stack.Count == 0)
            {
                return -1;
            }

            return this.stack[this.top];
        }

        public int GetMin()
        {
            if (this.stack.Count == 0)
            {
                return -1;
            }

            var minElement = this.stack[0];
            for (int i = 1; i < this.stack.Count; i++)
            {
                if (this.stack[i] < minElement)
                {
                    minElement = this.stack[i];
                }
            }

            return minElement;
        }
    }
}

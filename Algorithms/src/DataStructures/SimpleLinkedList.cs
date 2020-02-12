namespace DataStructures
{
    using System.Collections.Generic;

    public class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    public class SimpleLinkedList
    {
        private Node node = null;
        private Node head = null;

        public SimpleLinkedList(int data)
        {
            node = new Node(data);
            this.head = node;
        }

        public void AddAfter(int data)
        {
            this.node.Next = new Node(data);
            this.node = this.node.Next;
        }

        public void AddBefore(int data)
        {
            var previousNode = this.head;
            this.head = new Node(data) { Next = previousNode };
        }

        public void Reverse()
        {
            var currentNode = this.head;
            Node previousNode = null;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;
                
                currentNode.Next = previousNode;
                previousNode = currentNode;
                
                currentNode = nextNode;
            }

            head = previousNode;
        }

        public IList<int> GetElements()
        {
            var elements = new List<int>();
            var currentNode = this.head;

            while (currentNode != null)
            {
                elements.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }

            return elements;
        }
    }
}

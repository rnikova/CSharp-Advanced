namespace Workshop
{
    using System;

    public class DoublyLinkedList
    {
        private class ListNode
        {
            public int Value { get; }

            public ListNode NextNode { get; set; }

            public ListNode PreviousNode { get; set; }

            public ListNode(int value)
            {
                this.Value = value;
            }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int value)
        {
            ListNode newHead = new ListNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(int value)
        {
            ListNode newTail = new ListNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public int RemoveFirst()
        {
            if (this.Count==0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            int fisrtElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head==null)
            {
                this.tail = null;
            }
            else
            {
                this.head.PreviousNode = null;
            }

            this.Count--;

            return fisrtElement;
        }

        public void Print(Action<int> action)
        {
            ListNode currentNode = this.head;

            while (currentNode!=null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
    }
}

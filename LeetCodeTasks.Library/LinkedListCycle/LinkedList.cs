namespace LeetCodeTasks.Library.LinkedListCycle
{
    public class LinkedList<T>
    {
        private Node<T> _head;

        public LinkedList()
        {
            
        }

        public void AppendLast(Node<T> newNode)
        {
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public bool IsCycle()
        {
            var slowPointer = _head;
            var fastPointer = _head;

            while (fastPointer != null && fastPointer.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next;

                if (fastPointer == slowPointer)
                    return true;
            }
            
            return false;
        }

        public Node<T> FindMiddleNode()
        {
            var slowPointer = _head;
            var fastPointer = _head;

            while (fastPointer != null && fastPointer.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next;
            }

            return slowPointer;
        }
    }
}
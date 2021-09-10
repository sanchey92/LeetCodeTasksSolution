namespace LeetCodeTasks.Library.RemoveLinkedListElements
{
    public class LinkedListWithRemoveElements
    {
        private ListNode _head;

        public LinkedListWithRemoveElements()
        {
        }

        private void AppendLast(ListNode newNode)
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

        public ListNode RemoveElements(int value)
        {
            var result = new ListNode(0);
            result.Next = _head;

            var current = result;

            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
            
            return result.Next;
        }
    }
}
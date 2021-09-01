namespace LeetCodeTasks.Library.LinkedListReverse
{
    public static class LinkedListReverseSolution
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;

            while (head != null)
            {
                var next = head.Next;
                head.Next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }
    }
}u
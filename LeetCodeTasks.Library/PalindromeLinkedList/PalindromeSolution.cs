namespace LeetCodeTasks.Library.PalindromeLinkedList
{
    public class PalindromeSolution
    {
        private static ListNode ReverseList(ListNode head)
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

        private static ListNode FindMiddle(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head;

            while (fastPointer != null && fastPointer.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next;
            }

            return slowPointer;
        }

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;
            
            var middle = FindMiddle(head);
            var reverse = ReverseList(middle);

            while (reverse != null)
            {
                if (reverse.Value != head.Value)
                    return false;

                reverse = reverse.Next;
                head = head.Next;
            }

            return true;
        }
    }
}
namespace LeetCodeTasks.Library.MergeTwoSortedLists
{
    public static class MergeSolution
    {
        public static ListNode MergeTwoSortedLists(ListNode list1, ListNode list2)
        {
            var mergedList = new ListNode(0);
            var result = mergedList;

            while (list1 != null && list2 != null)
            {
                if (list1.Value < list2.Value)
                {
                    mergedList.Next = new ListNode(list1.Value);
                    list1 = list1.Next;
                }
                else
                {
                    mergedList.Next = new ListNode(list2.Value);
                    list2 = list2.Next;
                }

                mergedList = mergedList.Next;
            }

            while (list1 != null)
            {
                mergedList.Next = new ListNode(list1.Value);
                list1 = list1.Next;
                mergedList = mergedList.Next; 
            }

            while (list2 != null)
            {
                mergedList.Next = new ListNode(list2.Value);
                list2 = list2.Next;
                mergedList = mergedList.Next;
            }

            return result.Next;
        }
    }
}
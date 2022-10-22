using CommonLibrary.LinkedList;

namespace Amazon.A011_Merge_Two_Sorted_Lists
{
    internal class Module
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var mergeNodeHead = new ListNode();
            var currNode = mergeNodeHead;
            var lp1 = list1;
            var lp2 = list2;
            int cnt = 0;

            while (lp1 != null || lp2 != null)
            {
                if (lp1 != null && lp2 != null)
                {
                    if (lp1.val <= lp2.val)
                    {
                        currNode.val = lp1.val;
                        lp1 = lp1.next;
                    }
                    else
                    {
                        currNode.val = lp2.val;
                        lp2 = lp2.next;
                    }
                }
                else if (lp1 != null)
                {
                    currNode.val = lp1.val;
                    lp1 = lp1.next;
                }
                else if (lp2 != null)
                {
                    currNode.val = lp2.val;
                    lp2 = lp2.next;
                }

                cnt++;

                if (lp1 != null || lp2 != null)
                {
                    currNode.next = new ListNode();
                    currNode = currNode.next;
                }
            }

            if (cnt == 0)
            {
                mergeNodeHead = null;
            }

            return mergeNodeHead;
        }
    }
}

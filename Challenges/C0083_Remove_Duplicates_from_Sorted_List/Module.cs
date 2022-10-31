using CommonLibrary.LinkedList;
using System.Diagnostics;

namespace Challenges.C0083_Remove_Duplicates_from_Sorted_List
{
    internal class Module
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var resultHead = new ListNode(head.val); // this will not change
            var resultTail = resultHead;
            int previousVal = head.val;
            var currPt = head.next;

            while (currPt != null)
            {
                if (currPt.val != previousVal)
                {
                    resultTail.next = new ListNode(currPt.val);
                    resultTail = resultTail.next;
                }

                previousVal = currPt.val;
                currPt = currPt.next;
            }

            return resultHead;
        }
    }
}

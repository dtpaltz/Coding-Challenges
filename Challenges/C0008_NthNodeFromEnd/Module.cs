using System.Diagnostics;

namespace Challenges.C0008_NthNodeFromEnd
{
    internal class Module
    {
        public LinkedListNode<int> NthToLast(LinkedListNode<int> head, int n)
        {
            // If list does not exist or if there are no elements in the list,return NULL
            if (head == null || n < 1)
            {
                return null;
            }

            // make pointers p1 and p2 point to the start of the list.
            LinkedListNode<int> p1 = head;
            LinkedListNode<int> p2 = head;

            // The key to this algorithm is to set p1 and p2 apart by n-1 nodes initially
            // so we want p2 to point to the (n-1)th node from the start of the list
            // then we move p2 till it reaches the last node of the list. 
            // Once p2 reaches end of the list p1 will be pointing to the nth node 
            // from the end of the list.

            // loop to move p2.
            for (int j = 0; j < n - 1; ++j)
            {
                // while moving p2 check if it becomes NULL, that is if it reaches the end
                // of the list. That would mean the list has less than n nodes, so its not 
                // possible to find nth from last, so return NULL.
                if (p2 == null)
                {
                    return null;
                }
                // move p2 forward.
                p2 = p2.Next;
            }

            // at this point p2 is (n-1) nodes ahead of p1. Now keep moving both forward
            // till p2 reaches the last node in the list.
            while (p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            // at this point p2 has reached the last node in the list and p1 will be
            // pointing to the nth node from the last..so return it.
            return p1;
        }
    }
}

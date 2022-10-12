using CommonLibrary.LinkedList;

namespace Amazon.A002_AddTwoNumbers
{
    internal class Module
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var currResultDigit = result;

            var digit1Node = l1;
            var digit2Node = l2;
            int carryOne = 0;

            while (true)
            {
                int resultDigit = 0;
                int digit1 = digit1Node == null ? 0 : digit1Node.val;
                int digit2 = digit2Node == null ? 0 : digit2Node.val;

                if (digit1 == 0 && digit2 == 0)
                {
                    break;
                }
                else
                {
                    resultDigit = digit1 + digit2;
                }

                resultDigit += carryOne;
                carryOne = resultDigit > 9 ? 1 : 0;
                resultDigit %= 10;

                currResultDigit.val = resultDigit;

                digit1Node = digit1Node?.next;
                digit2Node = digit2Node?.next;

                if (digit1Node != null || digit2Node != null)
                {
                    currResultDigit.next = new ListNode(0);
                    currResultDigit = currResultDigit.next;
                }
            }

            return result;

        }
    }
}

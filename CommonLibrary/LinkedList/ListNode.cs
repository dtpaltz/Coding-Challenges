namespace CommonLibrary.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(IEnumerable<int> nums)
        {
            var curr = this;
            int cnt = 0;

            foreach (var item in nums)
            {
                curr.val = item;
                cnt++;

                if (cnt < nums.Count())
                {
                    curr.next = new ListNode();
                    curr = curr.next;
                }
            }
        }

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
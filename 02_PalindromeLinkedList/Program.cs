namespace PalindromeLinkedList
{
    /**
     * Definition for singly-linked list.
     */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        private int Count(int counter, ListNode head)
        {
            if (head == null)
                return counter;
            return Count(counter+1, head.next);
        }

        private ListNode getLeft(int counter, int limit, ref Stack<int> prev, ListNode head)
        {
            var node = head.next;
            if (counter == limit)
                return node;
            prev.Push(node.val);
            return getLeft(counter + 1, limit, ref prev, node);
        }

        public bool IsPalindrome(ListNode head)
        {
            int length = Count(0, head);
            Console.Write(length);
            if (length == 1)
            {
                Console.WriteLine(true);
                return true;
            }

            Stack<int> firstHalf = new();
            firstHalf.Push(head.val);
            var secondHalf = getLeft(0, length / 2 - 1, ref firstHalf, head);
            if (length % 2 == 1)
            {
                secondHalf = secondHalf.next;
            }
            int val = 0;

            bool result = true;
            while (firstHalf.TryPop(out val))
            {
                if (secondHalf.val != val)
                {
                    result = false;
                    break;
                }
                secondHalf = secondHalf.next;
            }
            Console.WriteLine(result);
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //
            ListNode head1 = new(1, new ListNode(2, new ListNode(2, new ListNode(1))));
            ListNode head2 = new(1, new ListNode(2));
            ListNode head3 = new(1);
            ListNode head4 = new(1, new ListNode(2, new ListNode(1)));
            solution.IsPalindrome(head1);
            solution.IsPalindrome(head2);
            solution.IsPalindrome(head3);
            solution.IsPalindrome(head4);
        }
    }
}
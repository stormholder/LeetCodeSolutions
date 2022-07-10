namespace MiddleLinkedList;

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
        return Count(counter + 1, head.next);
    }

    private ListNode PeekSecondMiddle(int counter, int limit, ListNode head)
    {
        var node = head.next;
        if (counter == limit)
            return node;
        return PeekSecondMiddle(counter + 1, limit, node);
    }

    public ListNode MiddleNode(ListNode head)
    {
        int length = Count(0, head);
        return length == 1 ? head : PeekSecondMiddle(0, length / 2 - 1, head);
    }

    public List<int> ToList(ref List<int> list, ListNode head)
    {
        if (head == null)
            return list;
        list.Add(head.val);
        return ToList(ref list, head.next);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}
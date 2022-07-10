using MiddleLinkedList;

namespace _05_MiddleLinkedList.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        static object[] TestCases =
        {
            new object[] { 
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 
                new ListNode(3, new ListNode(4, new ListNode(5))) 
            },
            new object[] { 
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))), 
                new ListNode(4, new ListNode(5, new ListNode(6))) 
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(ListNode node, ListNode expected)
        {
            Solution solution = new();
            List<int> exp = new();
            List<int> act = new();
            var actual = solution.MiddleNode(node);
            solution.ToList(ref exp, expected);
            solution.ToList(ref act, actual);
            Assert.That(exp, Is.EquivalentTo(act));
        }
    }
}
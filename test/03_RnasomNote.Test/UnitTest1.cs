using RansomNote;

namespace _03_RnasomNote.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        static object[] TestCases =
        {
            new object[] { "a", "b", false },
            new object[] { "aa", "ab", false },
            new object[] { "aa", "aab", true }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test(string ransomNote, string magazine, bool expected)
        {
            Solution solution = new();
            Assert.That(solution.CanConstruct(ransomNote, magazine), Is.EqualTo(expected));
        }
    }
}
using FizzBuzz;

namespace _04_FizzBuzz.Test
{
    public class Tests
    {
        static object[] TestCases =
        {
            new object[] { 3, new string[3] { "1", "2", "Fizz" } },
            new object[] { 5, new string[5] { "1", "2", "Fizz", "4", "Buzz" } },
            new object[] { 15, new string[15] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int n, string[] expected)
        {
            Solution solution = new();
            Assert.That(expected, Is.EquivalentTo(solution.FizzBuzz(n)));
        }
    }
}
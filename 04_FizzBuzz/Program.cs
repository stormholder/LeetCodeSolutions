namespace FizzBuzz;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> list = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            var fizz = i % 3 == 0 ? "Fizz" : string.Empty;
            var buzz = i % 5 == 0 ? "Buzz" : string.Empty;
            string elem = string.Empty;
            if (string.IsNullOrEmpty(fizz) && string.IsNullOrEmpty(buzz))
            {
                list.Add(i.ToString());
                continue;
            }
            list.Add($"{fizz}{buzz}");
        }

        return list;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
    }
}
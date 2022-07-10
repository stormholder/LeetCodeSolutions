using System;

namespace RomanToInteger
{
    public class Solution
    {
        private int symbolToInt(char s)
        {
            return s switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }

        public int RomanToInt(string s)
        {
            var symbols = s.ToCharArray();
            int result = 0;
            int prevSymbolInt = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                int num = this.symbolToInt(symbols[i]);
                result += num;
                if (
                    (prevSymbolInt == 1 && (num == 5 || num == 10)) || 
                    (prevSymbolInt == 10 && (num == 50 || num == 100)) || 
                    (prevSymbolInt == 100 && (num == 500 || num == 1000))
                    )
                {
                    result -= prevSymbolInt + prevSymbolInt;
                }
                prevSymbolInt = num;
            }

            return result;
        }
    }

    //var solution = new Solution();
    internal class Program
    {
         static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] testCases = new string[4] { "III", "LVIII", "MCMXCIV", "DCXXI" };
            for (int i = 0; i < testCases.Length; i++)
            {
                Console.WriteLine($"{testCases[i]}={solution.RomanToInt(testCases[i])}");
            }
        }
    }
}
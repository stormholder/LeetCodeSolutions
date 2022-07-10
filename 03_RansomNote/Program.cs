namespace RansomNote;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }
        Dictionary<char, int> magazineCharDict = new();
        foreach (var mchar in magazine)
        {
            if (!magazineCharDict.ContainsKey(mchar))
            {
                magazineCharDict.Add(mchar, 0);
            }
            magazineCharDict[mchar] = magazineCharDict[mchar] + 1;
        }

        Stack<char> ransomChars = new Stack<char>();
        foreach (var rchar in ransomNote)
        {
            ransomChars.Push(rchar);
        }

        bool result = true;
        char letter;
        while (ransomChars.TryPop(out letter))
        {
            if (!magazineCharDict.ContainsKey(letter))
            {
                result = false;
                break;
            }
            if (magazineCharDict[letter] == 0)
            {
                magazineCharDict.Remove(letter);
                result = false;
                break;
            }
            magazineCharDict[letter] = magazineCharDict[letter] - 1;
        }

        return result;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
    }
}
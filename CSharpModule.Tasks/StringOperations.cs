namespace CSharpModule.Tasks;

public class StringOperations
{
    public string Reverse(string str) 
    {
        string reverseStr = string.Empty;
        for (int i = str.Length - 1; i >=0; i--) 
        {
            reverseStr += str[i];
        }
        return reverseStr;
    }

    public bool AreAnagrams(string str1, string str2)
    {
        return false;
    }

    public string LongestPalindromeWithin(string str) 
    {
        return str;
    }

    public string RemoveDuplicates(string str) 
    {
        return str;
    }

    public bool IsValidPalindrome(string str) 
    {
        return false;
    }

    public char FirstNonRepeatedCharacter(string str) 
    {
        return 'a';
    }

    public string Compress(string str) 
    {
        return str;
    }

}
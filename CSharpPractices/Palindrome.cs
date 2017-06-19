using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices
{
    class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            if (word.Length == 0)
            {
                return false;
            }
            string first = word.Substring(0, word.Length / 2);
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second, StringComparison.OrdinalIgnoreCase);
        }
    }
}

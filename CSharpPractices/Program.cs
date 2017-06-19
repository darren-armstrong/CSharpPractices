using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractices.UserInput;

namespace CSharpPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome Example
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
            Console.ReadLine();
            //User Input Example
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadLine();
        }
    }
}

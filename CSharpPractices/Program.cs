﻿using System;
using System.Collections.Generic;
using CSharpPractices.BinarySearchTree;
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

            Console.WriteLine("Enter a character : ");
            input.Add(Console.ReadKey().KeyChar);
            Console.WriteLine("");
            Console.WriteLine("Enter a character : ");
            input.Add(Console.ReadKey().KeyChar);
            Console.WriteLine("");
            Console.WriteLine("Enter a character : ");
            input.Add(Console.ReadKey().KeyChar);
            Console.WriteLine("");
            Console.WriteLine(input.GetValue());
            Console.ReadLine();

            //TwoSum Example
            Tuple<int?, int?> indices = TwoSum.FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
            Console.ReadLine();

            //Binary Search Tree Example
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(BinarySearchTree.BinarySearchTree.Contains(n2, 3));
            Console.WriteLine(BinarySearchTree.BinarySearchTree.Contains(n2, 5));
            Console.ReadLine();
        }
    }
}

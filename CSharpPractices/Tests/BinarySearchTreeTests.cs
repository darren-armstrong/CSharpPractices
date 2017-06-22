using CSharpPractices.BinarySearchTree;
using Xunit;

namespace CSharpPractices.Tests
{

    public class BinarySearchTreeTests
    {
        /* Binary search tree (BST) is a binary tree where the value of each node is larger 
         * or equal to the values in all the nodes in that node's left subtree and 
         * is smaller than the values in all the nodes in that node's right subtree.
         * 
         * Write a function that checks if a given binary search tree contains a given value.
         * 
         * For example, for the following tree:
         *      n1 (Value: 1, Left: null, Right: null)
         *      n2 (Value: 2, Left: n1, Right: n3)
         *      n3 (Value: 3, Left: null, Right: null)
         *      Call to Contains(n2, 3) should return true since a tree with root at n2 contains number 3.
         */

        [Fact]
        public void NodeThatDoesContain()
        {
            Node test = new Node(1, null, null);
            Assert.Equal(true, BinarySearchTree.BinarySearchTree.Contains(test, 1));
        }

        [Fact]
        public void NodeThatDoesNotContain()
        {
            Node test = new Node(1, null, null);
            Assert.Equal(false, BinarySearchTree.BinarySearchTree.Contains(test, 2));
        }

        [Fact]
        public void NodewithNodeValuesThatDoesNotContain()
        {
            Node test = new Node(1, null, null);
            Node test2 = new Node(3, null, null);
            Node test3 = new Node(2, test, test2);
            Assert.Equal(false, BinarySearchTree.BinarySearchTree.Contains(test3, 10));
        }

        [Fact]
        public void NodewithNodeValuesThatDoesContain()
        {
            Node test = new Node(1, null, null);
            Node test2 = new Node(3, null, null);
            Node test3 = new Node(2, test, test2);
            Assert.Equal(true, BinarySearchTree.BinarySearchTree.Contains(test3, 3));
        }

    }
}



namespace CSharpPractices.BinarySearchTree
{
    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            while (root != null)
            {
                if (root.Value == value)
                {
                    return true;
                }
                root = root.Value > value ? root.Left : root.Right;
            }
            return false;
        }
    }
}

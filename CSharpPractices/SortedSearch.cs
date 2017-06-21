
namespace CSharpPractices
{
    class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int min = 0;
            int max = sortedArray.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                if (sortedArray[max] < lessThan)
                {
                    return max + 1;
                }
                mid = (min + max) / 2;
                if (sortedArray[mid] < lessThan)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return mid;
        }
    }
}

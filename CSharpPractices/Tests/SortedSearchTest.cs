using Xunit;

namespace CSharpPractices.Tests
{
    public class SortedSearchTest
    {
        [Fact]
        public void NoValuesInTheArrayLessThan()
        {
            Assert.Equal(0, SortedSearch.CountNumbers(new int[] { 5, 6, 7, 8 }, 4));
        }

        [Fact]
        public void ValuesInTheArrayLessThan()
        {
            Assert.Equal(2, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        }

        [Fact]
        public void ValuesInTheLongArrayLessThan()
        {
            Assert.Equal(11, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7, 8, 9, 10, 11, 12, 13, 14, 16 }, 15));
        }

        [Fact]
        public void ValuesInTheSmallArrayLessThan()
        {
            Assert.Equal(2, SortedSearch.CountNumbers(new int[] { 1, 3}, 4));
        }

        [Fact]
        public void ReturnZeroIfEmptyListIsPassedThrough()
        {
            Assert.Equal(0, SortedSearch.CountNumbers(new int[] {}, 4));
        }

        [Fact]
        public void ValueInTheArrayLessThan()
        {
            Assert.Equal(1, SortedSearch.CountNumbers(new int[] { 1 }, 4));
        }

        [Fact]
        public void ValueNotInTheArrayLessThan()
        {
            Assert.Equal(0, SortedSearch.CountNumbers(new int[] { 4 }, 1));
        }

        [Fact]
        public void MaxValueInArrayIsLessThan()
        {
            Assert.Equal(9, SortedSearch.CountNumbers(new int[] { 1,2,3,4,5,6,7,8,9 }, 10));
        }
    }
}

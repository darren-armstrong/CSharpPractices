using Xunit;

namespace CSharpPractices.Tests
{
    public class PalindromeTest
    {
        [Fact]
        public void InsertAPalindromeWithUppercase()
        {
            Assert.Equal(true, Palindrome.IsPalindrome("Deleveled"));
        }

        [Fact]
        public void InsertAPalindromeAllLowercase()
        {
            Assert.Equal(true, Palindrome.IsPalindrome("deleveled"));
        }

        [Fact]
        public void PassThroughAnEmptyString()
        {
            Assert.Equal(false, Palindrome.IsPalindrome(""));
        }

        [Fact]
        public void PassThroughAPalindromeWithNumbers()
        {
            Assert.Equal(true, Palindrome.IsPalindrome("1DeLevEled1"));
        }

        [Fact]
        public void PassThroughAnOddPalindrome()
        {
            Assert.Equal(true, Palindrome.IsPalindrome("testtset"));
        }
    }
}

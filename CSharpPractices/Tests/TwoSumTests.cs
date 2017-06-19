using System;
using System.Collections.Generic;
using Xunit;

namespace CSharpPractices.Tests
{
    public class TwoSumTests
    {
        /*
         * given a list and a target sum, returns zero-based indices of any two distinct elements 
         * whose sum is equal to the target sum. 
         * If there are no such elements, the function should return null.
         * 
         * For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return a Tuple<int, int> 
         * containing any of the following pairs of indices:
         * 
         * 1 and 4 (3 + 9 = 12)
         * 2 and 3 (5 + 7 = 12)
         * 3 and 2 (7 + 5 = 12)
         * 4 and 1 (9 + 3 = 12)
         * 
         */

        [Fact]
        public void NoneMatchTheSumReturnsNull()
        {
            Tuple<int?, int?> indices = TwoSum.FindTwoSum(new List<int>() { 0, 1, 2 }, 20);
            Assert.Equal(null, indices.Item1);
            Assert.Equal(null, indices.Item2);
        }

        [Fact]
        public void EmptyListReturnsNull()
        {
            Tuple<int?, int?> indices = TwoSum.FindTwoSum(new List<int>(), 20);
            Assert.Equal(null, indices.Item1);
            Assert.Equal(null, indices.Item2);
        }

        [Fact]
        public void MatchReturned()
        {
            Tuple<int?, int?> indices = TwoSum.FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
            Assert.IsType<int>(indices.Item1);
            Assert.IsType<int>(indices.Item2);
        }

        [Fact]
        public void MatchFoundButSameIndexAndNoOtherMatches()
        {
            Tuple<int?, int?> indices = TwoSum.FindTwoSum(new List<int>() { 6, 3, 10 }, 12);
            Assert.Equal(null, indices.Item1);
            Assert.Equal(null, indices.Item2);
        }
    }
}

using Main;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void LengthOfLongestSubstringTest()
        {
            var a = new Solution();
            var count = a.LengthOfLongestSubstring("aab");
            _testOutputHelper.WriteLine(count.ToString());
            Assert.True(count == 3);
        }
        [Fact]
        public void FindMedianSortedArraysTest()
        {
            var a = new Solution();
            var nums1 = new int[] { 1, 2 };
            var nums2 = new int[] { 3, 4 };
            var result = a.FindMedianSortedArrays(nums1, nums2);
            _testOutputHelper.WriteLine(result.ToString());
        }
        [Fact]
        public void ConvertTest()
        {
            var a = new Solution();
            var s = "PAYPALISHIRING";
            var result = a.ConvertOther(s, 5);
            _testOutputHelper.WriteLine(result.ToString());
        }
        [Fact]
        public void ReverseTest()
        {
            var a = new Solution();
            var result = a.Reverse2(12345678);
            _testOutputHelper.WriteLine(result.ToString());
        }
        [Fact]
        public void MaxAreaTest()
        {
            var a = new Solution();
            var result = a.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            _testOutputHelper.WriteLine(result.ToString());
        }
        [Fact]
        public void NumberToWordsTest()
        {
            var a = new Solution();
            var result = a.NumberToWords(12345);
            _testOutputHelper.WriteLine(result.ToString());
        }
        [Fact]
        public void LongestCommonPrefixTest()
        {
            var a = new Solution();
            var result = a.LongestCommonPrefix2(new String[] { "aa", "a" });
            _testOutputHelper.WriteLine(result.ToString());
        }
    }
}

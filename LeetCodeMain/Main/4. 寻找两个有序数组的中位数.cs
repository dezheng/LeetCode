using System;

namespace Main
{
    //todo:check
    public partial class Solution
    {
        //给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。
        //请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
        //你可以假设 nums1 和 nums2 不会同时为空。
        //示例 1:
        //nums1 = [1, 3]
        //nums2 = [2]
        //则中位数是 2.0
        //示例 2:
        //nums1 = [1, 2]
        //nums2 = [3, 4]
        //则中位数是 (2 + 3)/2 = 2.5
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            if (m > n)
            {
                return FindMedianSortedArrays(nums2, nums1); // 保证 m <= n
            }
            int iMin = 0, iMax = m;
            var middle = (m + n + 1) / 2;
            while (iMin <= iMax)
            {
                int i = (iMin + iMax) / 2;
                int j = middle - i;
                if (j != 0 && i != m && nums2[j - 1] > nums1[i])
                { // i 需要增大
                    iMin = i + 1;
                }
                else if (i != 0 && j != n && nums1[i - 1] > nums2[j])
                { // i 需要减小
                    iMax = i - 1;
                }
                else
                { // 达到要求，并且将边界条件列出来单独考虑
                    int maxLeft = 0;
                    if (i == 0) { maxLeft = nums2[j - 1]; }
                    else if (j == 0) { maxLeft = nums1[i - 1]; }
                    else { maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]); }
                    if ((m + n) % 2 == 1) { return maxLeft; } // 奇数的话不需要考虑右半部分

                    int minRight = 0;
                    if (i == m) { minRight = nums2[j]; }
                    else if (j == n) { minRight = nums1[i]; }
                    else { minRight = Math.Min(nums2[j], nums1[i]); }

                    return (maxLeft + minRight) / 2.0; //如果是偶数的话返回结果
                }
            }
            return 0;
        }

        public double QuickFindMedianSortedArray(int[] nums1, int[] nums2)
        {
            int indexAL = 1;
            int indexBL = 1;
            int indexAR = nums1.Length;
            int indexBR = nums2.Length;
            int left = 0;
            int right = 0;
            int findIndex = (nums1.Length + nums2.Length + 1) / 2;
            for (int i = 0; i < findIndex; i++)
            {
                // left
                if (indexAL > nums1.Length)
                {
                    left = nums2[indexBL - 1];
                    indexBL++;
                }
                else if (indexBL > nums2.Length)
                {
                    left = nums1[indexAL - 1];
                    indexAL++;
                }
                else if (nums1[indexAL - 1] < nums2[indexBL - 1])
                {
                    left = nums1[indexAL - 1];
                    indexAL++;
                }
                else
                {
                    left = nums2[indexBL - 1];
                    indexBL++;
                }
                // right
                if (indexAR == 0)
                {
                    right = nums2[indexBR - 1];
                    indexBR--;
                }
                else if (indexBR == 0)
                {
                    right = nums1[indexAR - 1];
                    indexAR--;
                }
                else if (nums1[indexAR - 1] > nums2[indexBR - 1])
                {
                    right = nums1[indexAR - 1];
                    indexAR--;
                }
                else
                {
                    right = nums2[indexBR - 1];
                    indexBR--;
                }
            }

            return (left + right) / 2.0;
        }
    }
}

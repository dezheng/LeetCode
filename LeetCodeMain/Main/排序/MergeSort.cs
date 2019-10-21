using System;

namespace Main.排序
{
    class MergeSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] items)
        {
            if (items.Length < 2)
            {
                return;
            }

            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;

            T[] left = new T[leftSize];
            T[] right = new T[rightSize];

            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);

            Sort(left);
            Sort(right);
            Merge(items, left, right);
        }

        private static void Merge(T[] items, T[] left, T[] right)
        {
            var leftIndex = 0;
            var rightIndex = 0;

            for (var i = 0; i < items.Length; i++)
            {
                if (leftIndex >= left.Length)
                {
                    items[i] = right[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex >= right.Length)
                {
                    items[i] = left[leftIndex];
                    leftIndex++;
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[i] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    items[i] = right[rightIndex];
                    rightIndex++;
                }
            }
        }
    }
}
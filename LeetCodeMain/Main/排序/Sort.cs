using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Main.排序
{
    public class Sort
    {
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                if (min != i)
                {
                    int t = arr[min];
                    arr[min] = arr[i];
                    arr[i] = t;
                }

            }
            return arr;
        }
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var temp = arr[i];
                int j;
                for ( j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > temp)
                    {
                        arr[j + 1] = arr[j];
                    }
                    else
                    {
                        break;
                    }
                }

                arr[j + 1] = temp;
            }
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j > 0 && arr[j - 1] > arr[j]; j--)
            //    {
            //        int temp = arr[j];      //交换操作
            //        arr[j] = arr[j - 1];
            //        arr[j - 1] = temp;
            //    }
            //}

            return arr;
        }

        public static int[] BubbleSort(int[] arr)
        {
            var done = false;
            var j = 1;
            while ((j < arr.Length) && (!done))//判断长度    
            {
                done = true;
                for (int i = 0; i < arr.Length - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        done = false;
                        var temp = arr[i];
                        arr[i] = arr[i + 1];//交换数据    
                        arr[i + 1] = temp;
                    }
                }
                j++;
            }

            return arr;
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="array">要排序的数组</param>
        /// <param name="low">下标开始位置，向右查找</param>
        /// <param name="high">下标开始位置，向左查找</param>
        public static void FastSort(int[] array, int low, int high)
        {
            if (low >= high)
                return;
            int index = SortUnit(array, low, high);
            FastSort(array, low, index - 1);
            FastSort(array, index + 1, high);
        }

        /// <summary>
        /// 单元排序
        /// </summary>
        /// <param name="array">要排序的数组</param>
        /// <param name="low">下标开始位置，向右查找</param>
        /// <param name="high">下标开始位置，向右查找</param>
        /// <returns>每次单元排序的停止下标</returns>
        public static int SortUnit(int[] array, int low, int high)
        {
            int key = array[low];//基准数
            while (low < high)
            {
                //从high往前找小于或等于key的值
                while (low < high && array[high] > key)
                    high--;
                //比key小开等的放左边
                array[low] = array[high];
                //从low往后找大于key的值
                while (low < high && array[low] <= key)
                    low++;
                //比key大的放右边
                array[high] = array[low];
            }
            //结束循环时，此时low等于high，左边都小于或等于key，右边都大于key。将key放在游标当前位置。 
            array[low] = key;
            return high;
        }
    }
}

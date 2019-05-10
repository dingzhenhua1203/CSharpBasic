using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDemo.SortMethod
{
    public class SortHelper
    {
        //1 9 4 8 6 7 2 3 5

        /// <summary>
        /// 直接插入排序
        /// </summary>
        public static void StraightInsertionSort(int[] arr)
        {
            #region 基本思想
            /* 将一个记录插入到已排序好的有序表中，从而得到一个新，记录数增1的有序表。
             * 即：先将序列的第1个记录看成是一个有序的子序列，然后从第2个记录逐个进行插入，直至整个序列有序为止。
             * 如果碰见一个和插入元素相等的，那么插入元素把想插入的元素放在相等元素的后面。
             * 所以，相等元素的前后顺序没有改变，从原无序序列出去的顺序就是排好序后的顺序
             * 所以插入排序是稳定的
             */
            #endregion
            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i-1])
                {
                    temp = arr[i];
                    arr[i] = arr[i-1];

                }
                for (int j = i-1; j < i; j--)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            #region 基本思想
            /* 在要排序的一组数中，对当前还未排好序的范围内的全部数，自上而下对相邻的两个数依次进行比较和调整，让较大的数往下沉，较小的往上冒。
             * 即：每当两相邻的数比较后发现它们的排序与排序要求相反时，就将它们互换
             */
            #endregion
            int temp;
            for (int i = 0; i < arr.Length - 2; i++)
                for (int j = arr.Length - i - 1; j <= arr.Length - i - 1 && j > 1; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
        }
        /// <summary>
        /// 简单选择排序
        /// </summary>
        public static void SimpleSelectionSort()
        {
            #region 基本思想
            /* 在要排序的一组数中，选出最小（或者最大）的一个数与第1个位置的数交换；然后在剩下的数当中再找最小（或者最大）的与第2个位置的数交换，
             * 依次类推，直到第n-1个元素（倒数第二个数）和第n个元素（最后一个数）比较为止。
             * 第一趟，从n 个记录中找出关键码最小的记录与第一个记录交换
             * 第二趟，从第二个记录开始的n-1 个记录中再选出关键码最小的记录与第二个记录交换
             * 以此类推.....
             * 第i 趟，则从第i 个记录开始的n-i+1 个记录中选出关键码最小的记录与第i 个记录交换
             * 直到整个序列按关键码有序。
             */
            #endregion
        }
        /// <summary>
        /// 快速排序
        /// </summary>
        public static void QuickSort()
        {
            #region 基本思想
            /* 1）选择一个基准元素,通常选择第一个元素或者最后一个元素
             * 2）通过一趟排序讲待排序的记录分割成独立的两部分，其中一部分记录的元素值均比基准元素值小。另一部分记录的 元素值比基准值大。
             * 3）此时基准元素在其排好序后的正确位置
             * 4）然后分别对这两部分记录用同样的方法继续进行排序，直到整个序列有序。 
             */
            #endregion
        }
    }
}

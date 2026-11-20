using System;
using System.Collections.Generic;
using System.Text;

namespace dava13
{
    // ჯენერიკი - ზოგადი
    // extention method  this
    internal static class ArrayHelper
    {
        public static void PrintReverse<T>(this T[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static T GetFirstElement<T>(this T[] arr)
        {
            foreach (var item in arr)
            {
                return item;
            }

            return default;
        }

        public static T GetLastElement<T>(this T[] arr)
        {
            T temp = default;

            foreach (var item in arr)
            {
                temp = item;
            }

            return temp;
        }

        public static bool ContainsElement<T>(this T[] arr, T el)
        {
            foreach (var item in arr)
            {
                if (item.Equals(el))
                {
                    return true;
                }
            }

            return false;
        }

        public static int CountElements<T>(this T[] arr)
        {
            int count = 0;

            foreach (var item in arr)
            {
                count++;
            }

            return count;
        }

        public static int FindIndex<T>(this T[] arr, T el)
        {
            int index = 0;

            foreach (var item in arr)
            {
                if (item.Equals(el))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public static T[] Swap<T>(this T[] arr, int ind1, int ind2)
        {
            T temp = arr[ind1];
            arr[ind1] = arr[ind2];
            arr[ind2] = temp;

            return arr;
        }
    }
}
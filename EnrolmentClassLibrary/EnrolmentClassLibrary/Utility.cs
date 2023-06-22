using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Utility
    {
        public static void bubble_sort_asc<T>(List<T> _list) where T : IComparable<T>
        {

            for (int j = 0; j <= _list.Count - 2; j++)
            {
                for (int i = 0; i <= _list.Count - 2; i++)
                {
                    if (_list[i].CompareTo(_list[i + 1]) > 0)
                    {
                        var temp = _list[i + 1];
                        _list[i + 1] = _list[i];
                        _list[i] = temp;
                    }
                }

            }

        }

        public static void bubble_sort_dsc<T>(List<T> _list) where T : IComparable<T>
        {

            for (int j = 0; j <= _list.Count - 2; j++)
            {
                for (int i = 0; i <= _list.Count - 2; i++)
                {
                    if (_list[i].CompareTo(_list[i + 1]) < 0)
                    {
                        var temp = _list[i + 1];
                        _list[i + 1] = _list[i];
                        _list[i] = temp;
                    }
                }

            }

        }

        public static void print<T>(List<T> _list)
        {
            foreach (var item in _list)
                Console.WriteLine(item);
        }


        //binary search
        public static int myBinarySearch<T>(List<T> _list, T x) where T : IComparable<T>
        {
            int left = 0;
            int right = _list.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int res = x.CompareTo(_list[mid]);

                if (res == 0)
                    return mid;
                if (res > 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }




        public static T anotherBinarySearch<T>(T[] array, T target) where T : IComparable<T>
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                int comparisonResult = target.CompareTo(array[middle]);

                if (comparisonResult == 0)
                {
                    return array[middle];
                }
                else if (comparisonResult < 0)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return default(T); // Not found
        }


        // sequential search
        public static int mySequentialSearch<T>(List<T> _List, T x) where T : IComparable<T>
        {
            for (int i = 0; i < _List.Count; i++)
            {
                if (_List[i].CompareTo(x) == 0)
                    return i;
            }
            return -1;
        }


        // linear search
        public static int myLinearSearch<T>(List<T> _List, T target)
        {
            for (int i = 0; i < _List.Count; i++)

                if (Comparer<T>.Default.Compare(_List[i], target) == 0)
                    return i;

            return -1; // Not found
        }

    }
}

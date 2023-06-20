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
        public static int MyBinarySearch<T>(List<T> _list, T x) where T : IComparable<T>
        {
            int left = 0;
            int right = _list.Count -1;
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

        // sequential search
        public static int MySequentialSearch<T>(List<T> _List, T x) where T : IComparable<T>
        {
            for (int i = 0; i < _List.Count; i++)
            {
                if (_List[i].CompareTo(x) == 0)
                    return i;
            }
            return -1;
        }

    }
}

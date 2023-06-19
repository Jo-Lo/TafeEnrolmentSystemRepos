using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Utility
    {
        static void bubble_sort_asc<T>(List<T> _list) where T : IComparable<T>
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

        static void bubble_sort_dsc<T>(List<T> _list) where T : IComparable<T>
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
    }
}

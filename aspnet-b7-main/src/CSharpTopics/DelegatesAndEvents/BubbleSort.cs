using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class BubbleSort<T>
    {
        public delegate int Compare(T item1, T item2);
        public static void Sort(T[] items, Compare compare)
        {
            for (int j = 0; j <= items.Length - 2; j++)
            {
                for (int i = 0; i <= items.Length - 2; i++)
                {
                    if (compare(items[i], items[i + 1]) == -1)
                    {
                        var temp = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = temp;
                    }
                }
            }
        }
    }
}

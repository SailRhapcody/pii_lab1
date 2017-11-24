using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class BubbleSort : ISorter
    {
        //Sort array using Bubble sort.
        public void sort(List<int> list)
        {
            for (int i = list.Count() - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
        }

    }
}

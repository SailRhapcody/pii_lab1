using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class SelectionSort : ISorter
    {
        public void sort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min_i = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[min_i])
                    {
                        min_i = j;
                    }
                }
                int temp = list[i];
                list[i] = list[min_i];
                list[min_i] = temp;
            }
        }
    }
}

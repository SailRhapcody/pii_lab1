using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class InsertionSort : ISorter
    {
        public void sort(List<int> list)
        {
            int Temp, j;
            for (int i = 1; i < list.Count; i++)
            {
                Temp = list[i];
                j = i;
                while (j > 0 && Temp < list[j - 1])
                {
                    list[j] = list[j - 1];
                    j--;
                };
                list[j] = Temp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab1
{
    class Tester
    {
        private List<int> list;
        private Stopwatch stopwatch;

        public void start(int sortType, int arrSize)
        {
            stopwatch = new Stopwatch();
            list = new List<int>();
            arrFiller(arrSize);
            stopwatch.Start();
            switch(sortType){
                case 0:
                    Console.Write("Bubble Sort, Size : " + arrSize);
                    BubbleSort bs = new BubbleSort();
                    bs.sort(list);
                    break;
                case 1:
                    Console.Write("Insertion Sort, Size : " + arrSize);
                    InsertionSort ins = new InsertionSort();
                    ins.sort(list);
                    break;
                case 2:
                    Console.Write("Selection Sort, Size : " + arrSize);
                    SelectionSort ss = new SelectionSort();
                    ss.sort(list);
                    break;
            }
            stopwatch.Stop();
            Console.WriteLine("; Time : " + stopwatch.Elapsed.TotalMilliseconds * 1000000);
        }

        private void arrFiller(int arrSize)
        {
            Random rnd = new Random();
            for(int i = 0;i < arrSize; i++)
            {
                list.Add(rnd.Next(1, 1000));
            }
        }

    }
}

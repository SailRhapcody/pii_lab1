using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester tester = new Tester();
            Console.WriteLine("--------------");
            tester.start(0, 10);
            Console.WriteLine("--------------");
            tester.start(0, 10);
            tester.start(1, 10);
            tester.start(2, 10);

            Console.WriteLine("--------------");
            tester.start(0, 100);
            Console.WriteLine("--------------");
            tester.start(0, 100);
            tester.start(1, 100);
            tester.start(2, 100);

            Console.WriteLine("--------------");
            tester.start(0, 1000);
            Console.WriteLine("--------------");
            tester.start(0, 1000);
            tester.start(1, 1000);
            tester.start(2, 1000);

            Console.WriteLine("--------------");
            tester.start(0, 10000);
            Console.WriteLine("--------------");
            tester.start(0, 10000);
            tester.start(1, 10000);
            tester.start(2, 10000);

        }

    }
}

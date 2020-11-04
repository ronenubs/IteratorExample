using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int number in SomeNumbers())
            {
                Console.Write(number.ToString() + " ");
            }

            Console.ReadLine();
        }

        private static System.Collections.IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 8;
        }
    }
}

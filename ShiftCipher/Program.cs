using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            ShiftCipher sc = new ShiftCipher();

            for (byte i = 0; i < 26; i++)
            {
                Console.WriteLine("{0} : {1}", i, sc.value[i]);
            }

            Console.ReadKey();
        }
    }
}

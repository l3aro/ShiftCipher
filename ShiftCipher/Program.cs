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
            ShiftCipher cp = new ShiftCipher();

            string encrypt = cp.Encrypt("attack");

            string decrypt = cp.Decrypt(encrypt);

            Console.ReadKey();
        }
    }
}

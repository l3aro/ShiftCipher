using System;

namespace ShiftCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            ShiftCipher cp = new ShiftCipher();

            Console.Write("Nhap chuoi can ma hoa: ");

            string data;

            data = Console.ReadLine();

            string encrypt = cp.Encrypt(data);

            Console.WriteLine("Chuoi da ma hoa: {0}", encrypt);

            string decrypt = cp.Decrypt(encrypt);

            Console.WriteLine("Chuoi da giai ma: {0}", decrypt);

            Console.ReadKey();
        }
    }
}

using System;

namespace ShiftCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            ShiftCipher ShiftCipher = new ShiftCipher();

            Console.Write("Nhap chuoi can ma hoa: ");

            string data;

            data = Console.ReadLine();

            int key = ShiftCipher.GetKey();

            string encrypt = ShiftCipher.Encrypt(data, key);

            Console.WriteLine("Chuoi da ma hoa: {0}", encrypt);

            string decrypt = ShiftCipher.Decrypt(encrypt, key);

            Console.WriteLine("Chuoi da giai ma: {0}", decrypt);

            Console.ReadKey();
        }
    }
}

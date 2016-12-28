using System;
using System.Collections.Generic;
using System.Text;

namespace ShiftCipher
{
    public class ShiftCipher
    {
        private int key;

        public ShiftCipher()
        {
            Random rnd = new Random();

            key = rnd.Next(1, 26);
        }

        public string Encrypt(string input)
        {
            input = input.ToUpper();

            byte[] toAlphabetNumber = Encoding.ASCII.GetBytes(input);

            for (int index = 0; index < toAlphabetNumber.Length; index++)
            {
                byte token = (byte)(toAlphabetNumber[index] - 65); // minus by 65 to back to Alphabet code context

                token = (byte)((token + key) % 26);

                token+= 65; // plus by 65 to back to ASCII character

                toAlphabetNumber[index] = token;
            }

            string result = Encoding.ASCII.GetString(toAlphabetNumber);

            return result;
        }

        public string Decrypt(string input)
        {
            input = input.ToUpper();

            byte[] toAlphabetNumber = Encoding.ASCII.GetBytes(input);

            for (int index = 0; index < toAlphabetNumber.Length; index++)
            {
                byte token = (byte)(toAlphabetNumber[index] - 65); // minus by 65 to back to Alphabet code context

                token = (byte)((token + 26 - key) % 26);

                token += 65; // plus by 65 to back to ASCII character

                toAlphabetNumber[index] = token;
            }

            string result = Encoding.ASCII.GetString(toAlphabetNumber);

            return result;
        }
    }
}

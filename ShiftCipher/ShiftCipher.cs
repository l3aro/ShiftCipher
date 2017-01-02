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

        // Remove characters not in Z26 alphabet
        public string RemoveNonZ26(string raw)
        {
            raw = raw.ToUpper();
            do
            {
                int i = 0;
                for (; i < raw.Length; i++)
                {
                    int ch = (int)raw[i];
                    if (ch < 65 || ch > 90)
                    {
                        raw = raw.Remove(i, 1);
                        break;
                    }
                }
                if (i == raw.Length)
                {
                    break;
                }
            }
            while (true);

            return raw;

        }

        public string Encrypt(string plainText)
        {
            plainText = RemoveNonZ26(plainText);

            byte[] toAlphabetNumber = Encoding.ASCII.GetBytes(plainText);

            for (int index = 0; index < toAlphabetNumber.Length; index++)
            {
                if (toAlphabetNumber[index] == 32)
                {
                    continue;
                }

                byte token = (byte)(toAlphabetNumber[index] - 65); // minus by 65 to back to Alphabet code context

                token = (byte)((token + key) % 26);

                token+= 65; // plus by 65 to back to ASCII character

                toAlphabetNumber[index] = token;
            }

            string result = Encoding.ASCII.GetString(toAlphabetNumber);

            return result;
        }

        public string Decrypt(string encrypted)
        {
            encrypted = RemoveNonZ26(encrypted);

            byte[] toAlphabetNumber = Encoding.ASCII.GetBytes(encrypted);

            for (int index = 0; index < toAlphabetNumber.Length; index++)
            {
                if (toAlphabetNumber[index] == 32)
                {
                    continue;
                }

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

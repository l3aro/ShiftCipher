using System;
using System.Collections.Generic;
using System.Text;

namespace ShiftCipher
{
    public class ShiftCipher
    {
        public Dictionary<byte, string> value { get; set; }
        private int key;

        public ShiftCipher()
        {
            value = new Dictionary<byte, string>();

            //Random rnd = new Random();

            //key = rnd.Next();

            key = 17;

            for (byte i = 0; i < 26; i++)
            {

                value.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i + 65) }));
            }
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
    }
}

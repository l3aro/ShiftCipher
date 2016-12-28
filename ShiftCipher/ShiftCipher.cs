using System.Collections.Generic;
using System.Text;

namespace ShiftCipher
{
    public class ShiftCipher
    {
        public Dictionary<byte, string> value { get; set; }

        public ShiftCipher()
        {
            value = new Dictionary<byte, string>();

            for (byte i = 0; i < 26; i++)
            {
                byte token = i;
                token += 65;
                value.Add(i, Encoding.ASCII.GetString(new byte[] { token }));
            }
        }
    }
}

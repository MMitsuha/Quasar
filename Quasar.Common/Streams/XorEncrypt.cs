using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quasar.Common.Streams
{
    public class XorEncrypt
    {
        private static readonly byte key = 0x11;

        public static void Encrypt(byte[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] ^= key;
            }
        }

        public static void Decrypt(byte[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] ^= key;
            }
        }
    }
}
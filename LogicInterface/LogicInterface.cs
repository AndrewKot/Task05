using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LogicInterface
{
    public static class TranslateToBinary
    {
        public static string GetDoubleInBit(double value)
        {
            unsafe
            {
                long* longTemp = (long*)&value;
                string tempString = Convert.ToString(*longTemp, 2);
                while (tempString.Length != 64)
                {
                    tempString = "0" + tempString;
                }
                return tempString;
            }
        }

        public static string GetDoubleInBit2(double value)
        {
            byte[] a = BitConverter.GetBytes(value);
            BitArray myBit = new BitArray(a);
            return GetStringFromBitArray(myBit);
        }

        private static string GetStringFromBitArray(BitArray bitArray)
        {
            StringBuilder str = new StringBuilder();
            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                str.Append(Convert.ToString(Convert.ToInt32(bitArray[i])));
            }
            return str.ToString();
        }

    }
}

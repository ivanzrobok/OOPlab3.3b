using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLab3._3B
{
    public class BitList : BitString
    {
        public BitList() : base() { }
        public BitList(long first, long second) : base(first, second) { }
        public BitList(BitString bit) : base(bit) { }
        public override void Write()
        {
            base.Write();
            Console.WriteLine($"Операція Not - {Not(this)}");
            Console.WriteLine($"Операція And - {And(this)}");
            Console.WriteLine($"Операція Or - {Or(this)}");
        }
        public static bool Not(BitString bit)
        {
            return bit.First != bit.Second;
        }
        public static bool And(BitString bit)
        {
            return IsNotZero(bit.First) && IsNotZero(bit.Second);
        }
        public static bool Or(BitString bit)
        {
            return IsNotZero(bit.First) || IsNotZero(bit.Second);
        }
        private static bool IsNotZero(long value)
        {
            return value != 0;
        }
    }
}

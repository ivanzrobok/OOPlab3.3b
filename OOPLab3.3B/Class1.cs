using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLab3._3B
{
    public class BitString
    {
        public BitString() { }
        public BitString(long first, long second)
        {
            First = first;
            Second = second;
        }
        public BitString(BitString bit)
        {
            First = bit.First;
            Second = bit.Second;
        }
        public long First { get; set; }
        public long Second { get; set; }

        public static BitString operator --(BitString count) =>
            new BitString { First = count.First - 1, Second = count.Second - 1 };
        public static BitString operator ++(BitString count) =>
            new BitString { First = count.First + 1, Second = count.Second + 1 };
        //оператори < і >
        public static bool operator <(BitString bit1, BitString bit2)=>
            bit1.First < bit2.First && bit1.Second < bit2.Second;
        public static bool operator >(BitString bit1, BitString bit2)=>
            bit1.First > bit2.First && bit1.Second > bit2.Second;
        //оператори <= і >=
        public static bool operator <=(BitString bit1, BitString bit2) =>
            bit1.First <= bit2.First && bit1.Second <= bit2.Second;
        public static bool operator >=(BitString bit1, BitString bit2) =>
            bit1.First >= bit2.First && bit1.Second >= bit2.Second;
        //оператори == і !=
        public static bool operator ==(BitString bit1, BitString bit2) =>
            bit1.First == bit2.First && bit1.Second == bit2.Second;
        public static bool operator !=(BitString bit1, BitString bit2) =>
            bit1.First != bit2.First && bit1.Second != bit2.Second;

        public void Read()
        {
            Console.Write("Введіть перше число : ");
            string firstCount = Console.ReadLine();
            Console.Write("Введіть друге число : ");
            string secondCount = Console.ReadLine();
            if (Check(firstCount) && Check(secondCount))
            {
                First = long.Parse(firstCount);
                Second = long.Parse(secondCount);
            }
            else throw new Exception("Ви ввели неправильне число");
        }
        public virtual void Write()
        {
            Console.WriteLine($"Перше число {First}, друге число {Second}.");
        }
        private bool Check(string count)
        {
            return count.Length == count.Where(x => char.IsDigit(x)).Count();
        }
    }
    
}



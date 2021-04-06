using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3._3B
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BitList bit1 = new BitList();
            BitList bit2 = new BitList();
            bit1.Read();
            bit2.Read();
            Console.WriteLine(BitList.And(bit1));
            Console.WriteLine(BitList.Not(bit1));
            Console.WriteLine(BitList.Or(bit1));

            Console.Write("bit1<bit2 : ");
            Console.WriteLine(bit1<bit2);

            Console.Write("bit1==bit2 : ");
            Console.WriteLine(bit1 == bit2);

            Console.Write("bit1<=bit2 : ");
            Console.WriteLine(bit1 <= bit2);


        }
    }
}

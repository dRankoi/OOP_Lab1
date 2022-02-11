using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int> { list = new int[] { 12, 3, 4 } };
            list.Append(5);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.GetArray());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasic
{
    internal class Program
    {
        private class Math {
            /*static public int Abs(int a)
            {
                return 0;
            }*/
        }

        static void Main(string[] args)
        {
            Math math = new Math();
            //Console.WriteLine(Math.Abs(-10));

            ThirdClass abc;
            ABCClass abc2;
            InnderClass inn;
            Console.WriteLine("Hello World!");
        }

        private class InnderClass
        {
        }
    }

    internal class ABCClass
    {
    }
}

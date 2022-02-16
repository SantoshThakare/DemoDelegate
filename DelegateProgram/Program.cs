using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProgram
{
    internal class Program
    {
        public delegate void operation(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Single Cast Delegates");
            operation obj = MultiCastDelegates.Add;
            obj(15, 5);
        }
    }
}


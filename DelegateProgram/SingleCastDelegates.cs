using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProgram
{
    public delegate void DelOp(int x, int y);
     class MultiCastDelegates
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition of 2 numbers       : {0}", a + b);
            Console.ReadLine();
        }
    }
    
    
}
        


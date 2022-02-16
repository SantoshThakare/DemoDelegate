using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine( "\n 1.Multi Delegates."
                                + "\n 2.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    
                    case 1:
                        Console.WriteLine("Multi Cast Delegates");
                        DelOp delOp = MultiCastDelegates.Add;
                        delOp += MultiCastDelegates.Sub;
                        delOp += MultiCastDelegates.Mul;
                        delOp += MultiCastDelegates.Div;
                        delOp(15, 5);
                        delOp(9, 3);
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter correct option");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}


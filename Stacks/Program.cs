using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Collections;
using System.IO;
using System.Xml;

namespace Test
{
    class Program
    {
        static void Main()
        {


            Stacks stack = new Stacks();
            stack.Push(1);
            stack.Push(10);
            stack.Push(100);


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadLine();          
                                         
        }                                
    }                                    
}                                        
                                             
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_stack_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("elementele din coada sunt:");
            stack.DisplayStack();

            stack.Pop();
            Console.WriteLine("coada dupa iesirea unui element:");
            stack.DisplayStack();
            Console.ReadLine();
        }
    }
}

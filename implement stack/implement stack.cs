using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            string a = Convert.ToString(stack.Pop());
            Console.WriteLine("ultimul element din coada este:" + a);
            //string b = Convert.ToString(stack.Peek());
            // Console.WriteLine(b);
            foreach (var item in stack)

            {
                Console.WriteLine("\t" + item);
            }
            Console.ReadKey();
        }
    }
}

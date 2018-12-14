using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_stack_with_methods
{
    class Stack
    {
        public List<int> stack = new List<int>();

        public void Push(int i)
        {
            stack.Add(i);
        }
        public void Pop()
        {
            stack.RemoveAt(stack.Count - 1);
        }
        public void DisplayStack()
        {
            foreach (var item in stack)

            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}

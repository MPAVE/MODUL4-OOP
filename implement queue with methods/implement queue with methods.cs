using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_queue_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            Console.Write("queue: ");
            q.DisplayQueue();
            q.Dequeue();
            Console.WriteLine("dequeue");
            q.DisplayQueue();
            Console.ReadLine();
        }
       
    }
}

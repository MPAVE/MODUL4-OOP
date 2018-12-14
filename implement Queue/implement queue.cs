using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_queue
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
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();

            Console.Write("Dequeue -> ");
            int a = (int)q.Dequeue();
            Console.WriteLine(a);

            Console.Write("queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
    


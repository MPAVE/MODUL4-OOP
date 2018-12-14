using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_queue_with_methods
{
    class Queue
    {
   
       public List<int> q = new List<int>();

        public void Enqueue(int i)
            {
                q.Add(i);
            }
            public void Dequeue()
            {
                q.RemoveAt(0);
            }
         public void DisplayQueue()
        {
            foreach (int i in q)
             Console.WriteLine(i + " "); 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class LimitedQueue<T>
    {
        readonly Queue<T> queue = new Queue<T>();
        public int Size { get; private set; }

        public LimitedQueue(int size)
        {
            Size = size;
        }

        public int Count { get => queue.Count; }

        public void Enqueue(T obj)
        {
            queue.Enqueue(obj);

            while (queue.Count > Size)
            {
                queue.Dequeue();
            }
        }

        public T Dequeue()
        {
            return queue.Count > 0 ? queue.Dequeue() : default;
        }
    }
}

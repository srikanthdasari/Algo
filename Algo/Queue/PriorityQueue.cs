/*using System.Collections.Generic;
using Algo.LinkedList;

namespace Algo.Queue
{
    public class PriorityQueue<T>:IEnumerable<T>
    {

        private SingleLinkedList<T> _items=new SingleLinkedList<T>();

        public PriorityQueue()
        {
            
        }

        public void Enqueue(T item)
        {
            if(_items.Count==0)
            {
                _items.AddLast(item);
            }
            else
            {
                var current =_items.Head;

                while(current!=null && current.Value.CompareTo(item)>0)
                {

                }
            }
        }
    }
}*/
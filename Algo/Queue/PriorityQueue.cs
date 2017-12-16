using System;
using System.Collections;
using System.Collections.Generic;
using Algo.LinkedList;

namespace Algo.Queue
{
    public class PriorityQueue<T>:IEnumerable<T> where T: IComparable<T>
    {

        //private SingleLinkedList<T> _items=new SingleLinkedList<T>();
        System.Collections.Generic.LinkedList<T> _items =
            new System.Collections.Generic.LinkedList<T>();   

        
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
                var current =_items.First;

                while(current!=null && current.Value.CompareTo(item)>0)
                {
                    current=current.Next;
                }

                if(current==null)
                {
                    _items.AddLast(item);
                }
                else
                {
                    _items.AddBefore(current,item);
                }
            }
        }


        public T Dequeue()
        {
            if(_items.Count==0)
            {
                throw new InvalidOperationException("The queue is Empty");
            }

            T Value=_items.First.Value;

            _items.RemoveFirst();

            return Value;
        }


        public T Peek()
        {
            if(_items.Count==0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            return _items.First.Value;
        }


        public int Count{
            get{
                return _items.Count;
            }
        }

        public void Clear()
        {
            _items.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using Algo.CommonClasses;
using Algo.LinkedList;
namespace Algo.Queue
{
    public class SimpleQueueUsingLinkedList<T>:IEnumerable<T>
    {
        private SingleLinkedList<T> _items=new SingleLinkedList<T>();

        public SimpleQueueUsingLinkedList()
        {

        }


        public void Enqueue(T item)
        {
            _items.AddLast(item);
        }

        public T Dequeue()
        {
            if(_items.Count==0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            T value=_items.Head.Value;

            _items.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if(_items.Count==0)
            {
                throw new InvalidOperationException("The queue is empty..");
            }

            return _items.Head.Value;
        }

        public int Count
        {
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
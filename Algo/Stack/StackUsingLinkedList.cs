using System;
using System.Collections;
using System.Collections.Generic;
using Algo.CommonClasses;
using Algo.LinkedList;

namespace Algo.Stack
{
    public class StackUsingLinkedList<T> :IEnumerable<T>
    {
        private SingleLinkedList<T> _list=new SingleLinkedList<T>();

        public void Push(T item)
        {
            _list.Add(item);
        }

        public T Pop()
        {
            if(_list.Count==0)
            {
                throw new InvalidOperationException("This stack is empty");
            }

            T value=_list.Head.Value;

            _list.RemoveFirst();

            return value;
        }


        public T Peek()
        {
            if(_list.Count==0)
            {
                throw new InvalidOperationException("ths stack is empty");
            }
            return _list.Head.Value;
        }

        public int Count
        {
            get{
                return _list.Count;
            }
        }

        public void Clear()
        {
            _list.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        } 

    }
}
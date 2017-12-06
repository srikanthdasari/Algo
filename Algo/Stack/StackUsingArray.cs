using System;
using System.Collections;
using System.Collections.Generic;

namespace Algo.Stack
{
    public class StackUsingArray<T>:IEnumerable<T>
    {
        T[] _items=new T[0];

        int _size;

        public void Push(T item)
        {
            if(_size==_items.Length)
            {
                //Initial size of 4, otherwise double the current length
                int newLength=_size==0?4:_size*2;

                //allocate , copy and assign the new array
                T[] newArray=new T[newLength];
                _items.CopyTo(newArray,0);
                _items=newArray;
            }

            _items[_size]=item;
            _size++;
        }

        //Removes and returns the top of from the stack
        public T Pop()
        {
            if(_size==0)
            {
                throw new InvalidOperationException("The stack is empty..");
            }

            _size--;
            return _items[_size];
        }

        // returns the top of the item from the stack without removing it from the stack
        public T Peek()
        {
            if(_size==0)
            {
                throw new InvalidOperationException("The stack is empty..");                
            }
            return _items[_size-1];
        }        

        public int Count
        {
            get
            {
                return _size;
            }
        }

        public void Clear()
        {
            _size=0;
        }

        //Enumerates each item in the stack in LIFO order. The stack remains unaltered.
        public IEnumerator<T> GetEnumerator()
        {
            for(int i=_size-1;i>=0;i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
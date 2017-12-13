using System;
using System.Collections;
using System.Collections.Generic;

namespace Algo.Queue
{
    public class SimpleQueueUsingArray<T>:IEnumerable<T>
    {
        public SimpleQueueUsingArray()
        {
            
        }

        T[] _items=new T[0];

        //the number of items in the queue
        int _size=0;
        // the index of the first (oldest) item in queue
        int _head=0;
        // the index of the last (newest) item in queue
        int _tail=-1;

        //
        /// <summary>
        /// Adds an item to back of queue
        /// </summary>
        /// <param name="_item">The item to place is Queue</param>
        /// <returns></returns>
        public void Enqueue(T _item)
        {
            //if the array needs to grow
            if(_items.Length==_size)
            {
                int newLength=(_size==0)?4:_size*2;

                T[] newArray=new T[newLength];

                if(_size>0)
                {
                    //copy contenst
                    //if the array has no wrapping, just copy the valid range
                    //else copy from head to end of the array and then from 0 to the tail
                    // if tails is less than head we have wrapped.
                     int targetIndex=0;   

                     if(_tail<_head)
                     {

                         //copy the _items[Head].._items[end] -> neaArray[0]..newArray[N]
                          for(int index=_head;index<_items.Length;index++)
                          {
                              newArray[targetIndex]=_items[index];
                              targetIndex++;
                          }  

                          for(int index=0;index<=_tail;index++)
                          {
                              newArray[targetIndex]=_items[index];
                              targetIndex++;
                          }
                     }
                     else
                     {
                         for(int index=_head;index<=_tail;index++)
                         {
                             newArray[targetIndex]=_items[index];
                             targetIndex++;
                         }
                     }
                    _head=0;
                    _tail=targetIndex-1;
                }
                else
                {
                    _head=0;
                    _tail=-1;
                }

                _items=newArray;
            }

            if(_tail==_items.Length-1)
            {
                _tail=0;
            }
            else
            {
                _tail++;
            }

            _items[_tail]=_item;
            _size++;
        }

        public T Dequeue()
        {
            if(_size==0)
            {
                throw new InvalidOperationException("The queue is  empty");
            }

            T value=_items[_head];

            if(_head==_items.Length-1)
            {
                //if the head is at the last index in the array - wrap around
                _head=0;
            }
            else
            {
                //move to next value
                _head++;
            }

            _size--;
            return value;
        }

        public T Peek()
        {
            if(_size==0)
            {
                throw new InvalidOperationException("This is Empty..");
            }

            return _items[_head];
        }

        public int Count
        {
            get{
                return _size;
            }
        }

        public void Clear()
        {
            _size=0;
            _head=0;
            _tail=-1;
        }


        public IEnumerator<T> GetEnumerator()
        {
            if(_size>0)
            {
                if(_tail<_head)
                {
                    for(int index=_head;index<_items.Length;index++)
                    {
                        yield return _items[index];
                    }

                    for(int index=0;index<=_tail;index++)
                    {
                        yield return _items[index];
                    }
                }
                else
                {
                    for(int index=_head;index<=_tail;index++)
                    {
                        yield return _items[index];
                    }    
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
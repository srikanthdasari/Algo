using System.Collections;
using System.Collections.Generic;
using Algo.CommonClasses;
namespace Algo.LinkedList
{
    public class SingleLinkedList<T>:ICollection<T>
    {
        public SingleLinkedListNode<T> Head
        {
            get; private set;
        }

        public SingleLinkedListNode<T> Tail
        {
            get; private set; 
        }


        public void AddFirst(T value)
        {
            //AddFirst(new SingleLinkedListNode<T>(value));
            if(value!=null)
            {
                var node=new SingleLinkedListNode<T>(value);
                SingleLinkedListNode<T> temp=Head;

                Head=node;

                Head.Next=temp;
                
                Count++;
            
                if(Count==1)
                {
                    Tail=Head;
                }
            }
        }

        public void AddLast(T value)
        {
            if(value!=null)
            {
                var node=new SingleLinkedListNode<T>(value);
                if(Count==0)
                {
                    Head=node;
                }
                else
                {
                    Tail.Next=node;
                }

                Tail=node;
                Count++;
            }
                
        }

       
        public void RemoveFirst()
        {
            if(Count!=0)
            {
                Head=Head.Next;
                Count--;
                if(Count==0)
                {
                    Tail=null;
                }
            }
        }

        public void RemoveLast()
        {
            if(Count!=0)
            {
                if(Count==1)
                {
                    Head=null;
                    Tail=null;
                }
                else
                {
                    SingleLinkedListNode<T> current=Head;
                    while(current.Next!=Tail)
                    {
                        current=current.Next;
                    }

                    current.Next=null;
                    Tail=current;
                }
                Count--;
            }
        }


        public int Count {get; private set;}

        public bool IsReadOnly
        {
           get{
               return false;
           }
       }

        public void Add(T item)
        {
            if(item!=null)
                AddFirst(item);
        }


        public void Clear()
        {
            Head=null;
            Tail=null;
            Count=0;
        }

        public bool Contains(T item)
        {
            SingleLinkedListNode<T> current=Head;
            while (current!=null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }

                current=current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            SingleLinkedListNode<T> current=Head;
            while(current!=null)
            {
                array[arrayIndex++]=current.Value;
                current=current.Next;
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            SingleLinkedListNode<T> current=Head;
            while(current!=null)
            {
                yield return current.Value;

                current=current.Next;
            }
        }

        public bool Remove(T item)
        {
            SingleLinkedListNode<T> previous=null;
            SingleLinkedListNode<T> current=Head;
            /*
                1. EmpltyList - do nothing
                2. Single Ndoe : (Previous is NULL)
                3. Many Nodes
                    a. node to remove is the first node
                    b. node to remove is the middle or last
             */

            while(current!=null)
            {
                if(current.Value.Equals(item))
                {
                    if(previous!=null)
                    {
                        previous.Next=current.Next;

                        if(current.Next==null)
                        {
                            Tail=previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }
                previous=current;
                current=current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
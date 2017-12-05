namespace Algo.CommonClasses
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode(T value)
        {
            Value=value;
        }

        public T Value {get;set;}

        public DoubleLinkedListNode<T> Next {get;set;}

        public DoubleLinkedListNode<T> Previous {get;set;}

    }
}
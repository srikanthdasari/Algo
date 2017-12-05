namespace Algo.CommonClasses
{
    public class SingleLinkedListNode<T>
    {
        public SingleLinkedListNode(T value)
        {
            Value=value;
        }

        public T Value {get;set;}

        public SingleLinkedListNode<T> Next {get;set;}
    }
}
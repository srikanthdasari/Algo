using System;

namespace Algo.CommonClasses
{
    public class BinaryTreeNode<TNode> :IComparable<TNode>
    where TNode:IComparable<TNode>
    {

        public BinaryTreeNode(TNode value)
        {
        
        }

        public BinaryTreeNode<TNode> Left {get;set;}
        public BinaryTreeNode<TNode> Right {get;set;}
        public TNode Value {get;set;}

        public int CompareTo(TNode other)
        {
            // 1 if the instance valuse is greater than the provided value, -1 if less or 0 if equal
            return Value.CompareTo(other);
        }
    }
}
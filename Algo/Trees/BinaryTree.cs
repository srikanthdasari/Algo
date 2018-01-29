using System;
using System.Collections;
using System.Collections.Generic;
using Algo.CommonClasses;

namespace Algo.Trees
{
    public class BinaryTree<T>:IEnumerable<T>
        where T:IComparable<T>
    {
        private BinaryTreeNode<T> _head;
        private int _count;


        public void Add(T value)
        {
            //if tree is empty - allocate the head
            if(_head==null)
            {
                _head=new BinaryTreeNode<T>(value);
            }
            //if the tree is not empty so find the righ location to insert
            else
            {
                AddTo(_head,value);    
            }

            _count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            //Case 1: Value is less than the current node value
            if(value.CompareTo(node.Value)<0)
            {
                //if there is no left child make this the new left
                if(node.Left==null)
                {
                    node.Left=new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            //Case 2: value is equal to or greater than the current value
            else
            {
                if(node.Right==null)
                {
                    node.Right=new BinaryTreeNode<T>(value);
                }   
                else
                {
                    AddTo(node.Right,value);
                }
            } 
        }

        public bool Contians(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent)!=null;
        }   

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current=_head;

            parent=null;

            while(current!=null)
            {
                int result=current.CompareTo(value);
                if(result>0)
                {
                    parent=current;
                    current=current.Left;
                }
                else if(result<0)
                {
                    parent=current;
                    current=current.Right;
                }
                else
                {
                    //we have match
                    break;
                }
            }
            
            return current;
        }


        public bool Remove(T value)
        {
            BinaryTreeNode<T> current , parent;

            current=FindWithParent(value, out parent);

            if(current==null)
            {
                return false;
            }

            _count--;

            // Case 1: If Curent has no right child, then currents left replaces current
            if(current.Right==null)
            {
                if(parent==null)
                {
                    _head=current.Left;
                }
                else
                {
                    int result=parent.CompareTo(current.Value);
                    if(result>0)
                    {
                        parent.Left=current.Left;
                    }
                    else if(result<0)
                    {
                        parent.Right=current.Left;
                    }
                }
            }

            //Case 2: If currents right child has no left child, then currents right child replaces current
            else if(current.Right.Left==null)
            {
                current.Right.Left=current.Left;

                if(parent==null)
                {
                    _head=current.Right;
                }
                else
                {
                    int result=parent.CompareTo(current.Value);
                    if(result>0)
                    {
                        parent.Left=current.Right;
                    }
                    else if(result<0)
                    {
                        parent.Right=current.Right;
                    }
                }
            }

            //Case 3: If currents right child has left child, replace current with currents right child left most child...

            else
            {
                BinaryTreeNode<T> leftMost=current.Right.Left;
                BinaryTreeNode<T> leftMostParent=current.Right;

                while(leftMost.Left!=null)
                {
                    leftMostParent=leftMost;
                    leftMost=leftMost.Left;
                }

                //the parents left subtree becmes the leftmosts right subtree
                leftMostParent.Left=leftMost.Right;

                //assign leftmosts left and right to currents left and right children
                leftMost.Left=current.Left;
                leftMost.Right=current.Right;

                if(parent==null)
                {
                    _head=leftMost;
                }
                else
                {
                    int result=parent.CompareTo(current.Value);
                    if(result>0)
                    {
                        //if parent value is greater than current value
                        // make leftmost the parents left child
                        parent.Left=leftMost;
                    }
                    else if(result<0)
                    {
                        //if parent value is less than the current value
                        // make leftmost the parents right child
                        parent.Right=leftMost;
                    }
                }
            }

            return true;
        }

            public void PreOrderTraversal(Action<T> action)
            {
                PreOrderTraversal(action,_head);
            }

            private void PreOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
            {
                if(node!=null)
                {
                    action(node.Value);
                    PreOrderTraversal(action,node.Left);
                    PreOrderTraversal(action, node.Right);
                }
            }


            public void PostOrderTraversal(Action<T> action)
            {
                PostOrderTraversal(action,_head);
            }

            private void PostOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
            {
                if(node!=null)
                {   
                    PostOrderTraversal(action, node.Left);
                    PostOrderTraversal(action,node.Right);
                    action(node.Value);
                }
            }

            public void InOrderTraversal(Action<T> action)
            {
                InOrderTraversal(action,_head);
            }

            private void InOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
            {
                if(node!=null)
                {
                    InOrderTraversal(action, node.Left);
                    action(node.Value);
                    InOrderTraversal(action, node.Right);
                }
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
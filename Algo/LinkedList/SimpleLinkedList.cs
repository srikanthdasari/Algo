using System;
using Algo.CommonClasses;
namespace Algo.LinkedList
{
    
    public class SimpleLinkedList
    {
        public  SimpleLinkedList()
        {
            
        }

        public void BuildList()
        {

            Node first=new Node{value=3};

            Node middle=new Node{value=5};

            Node last=new Node{value=7};

            first.next=middle;
            middle.next=last;

            PrntList(first);
        }
        private static void PrntList(Node node)
        {
            while(node!=null)
            {
                Console.Write(node.value);
                node=node.next;
            }
        }
    }


}
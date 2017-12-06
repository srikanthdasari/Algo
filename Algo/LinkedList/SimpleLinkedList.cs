using System;
using Algo.CommonClasses;
namespace Algo.LinkedList
{
    
    public class SimpleLinkedList
    {
        public  SimpleLinkedList()
        {
            
        }

        public string BuildList()
        {

            Node first=new Node{value=3};

            Node middle=new Node{value=5};

            Node last=new Node{value=7};

            first.next=middle;
            middle.next=last;

            return PrntList(first);
        }
        private string PrntList(Node node)
        {
            string str=string.Empty;
            
            while(node!=null)
            {
                str+=node.value.ToString();
                node=node.next;
            }        

            return str;    
        }
    }


}
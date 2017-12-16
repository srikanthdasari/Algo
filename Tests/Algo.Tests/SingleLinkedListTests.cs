using Algo.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algo.Tests
{
    [TestClass]
    public class SingleLinkedListTests
    {

        [TestMethod]
        public void EmptyList_AddTest()
        {
            _emptylist.Add("first");
            Assert.IsNotNull(_emptylist);
            Assert.AreEqual("first",_emptylist.Head.Value);
            Assert.AreEqual("first",_emptylist.Tail.Value);
            Assert.AreEqual(1,_emptylist.Count);
            Assert.IsNull(_emptylist.Head.Next);
            Assert.IsNull(_emptylist.Tail.Next);
        }

        [TestMethod]
        public void EmptyList_AddTest_WithNull()
        {
            _emptylist.Add(null);
            Assert.IsNotNull(_emptylist);
            Assert.AreEqual(0,_emptylist.Count);
            Assert.IsNull(_emptylist.Head);
            Assert.IsNull(_emptylist.Tail);
        }

        [TestMethod]
        public void EmptyList_RemoveTest_WithNull()
        {
            _emptylist.Remove(null);
            Assert.IsNotNull(_emptylist);
            Assert.AreEqual(0,_emptylist.Count);
            Assert.IsNull(_emptylist.Head);
            Assert.IsNull(_emptylist.Tail);
        } 


        [TestMethod]
        public void EmptyList_RemoveTest()
        {
            _emptylist.Remove("first");
            Assert.IsNotNull(_emptylist);
            Assert.AreEqual(0,_emptylist.Count);
            Assert.IsNull(_emptylist.Head);
            Assert.IsNull(_emptylist.Tail);
        }


        [TestMethod]
        public void ListwithOneCount_AddLast_WithNUll()
        {
            _listwithOneCount.AddLast(null);
            Assert.IsNotNull(_listwithOneCount);
            Assert.AreEqual(1,_listwithOneCount.Count);   
        }

        [TestMethod]
        public void ListwithOneCount_AddFirst_WithNUll()        
        {
            _listwithOneCount.AddFirst(null);
            Assert.IsNotNull(_listwithOneCount);
            Assert.AreEqual(1,_listwithOneCount.Count); 
        }

        [TestMethod]
        public void ListwithOneCount_AddFirst()
        {
            _listwithOneCount.AddFirst("second");
            Assert.AreEqual(2,_listwithOneCount.Count);
            Assert.AreEqual("second",_listwithOneCount.Head.Value);
            Assert.AreEqual("first",_listwithOneCount.Tail.Value);
            Assert.AreEqual(_listwithOneCount.Head.Next,_listwithOneCount.Tail);
            Assert.IsNull(_listwithOneCount.Tail.Next);
        }

        [TestMethod]
        public void ListwithOneCount_AddLast()
        {
            _listwithOneCount.AddLast("second");
            Assert.AreEqual(2,_listwithOneCount.Count);
            Assert.AreEqual("first",_listwithOneCount.Head.Value);
            Assert.AreEqual("second",_listwithOneCount.Tail.Value);   
            Assert.AreEqual(_listwithOneCount.Head.Next,_listwithOneCount.Tail);
            Assert.IsNull(_listwithOneCount.Tail.Next);
        }


        [TestMethod]
        public void ListwithOneCount_Add()
        {
            _listwithOneCount.Add("second");
            Assert.AreEqual(2,_listwithOneCount.Count);
            Assert.AreEqual("second",_listwithOneCount.Head.Value);
            Assert.AreEqual("first",_listwithOneCount.Tail.Value);   
            Assert.AreEqual(_listwithOneCount.Head.Next,_listwithOneCount.Tail);
            Assert.IsNull(_listwithOneCount.Tail.Next);
        }
        

        [TestMethod]
        public void ListwithOneCount_Remove_WithUnmatchedItem()
        {
            _listwithOneCount.Remove("second");
            Assert.AreEqual(1,_listwithOneCount.Count);
            Assert.AreEqual("first",_listwithOneCount.Head.Value);
            Assert.AreEqual("first",_listwithOneCount.Tail.Value);
            Assert.AreEqual(_listwithOneCount.Head,_listwithOneCount.Tail);            
        }

        [TestMethod]
        public void ListwithOneCount_Remove_WithMatchedItem()
        {
            _listwithOneCount.Remove("first");
            Assert.AreEqual(0,_listwithOneCount.Count);
            Assert.IsNull(_listwithOneCount.Head);
            Assert.IsNull(_listwithOneCount.Tail);
        }


        [TestMethod]
        public void ListwithTwoCount_Add()
        {
            _listwithTwoCount.Add("third");
            Assert.AreEqual(3,_listwithTwoCount.Count);
            Assert.AreEqual("third",_listwithTwoCount.Head.Value);
            Assert.AreEqual("first",_listwithTwoCount.Head.Next.Value);
            Assert.AreEqual("second",_listwithTwoCount.Tail.Value);            
        }


        [TestMethod]
        public void ListwithTwoCount_AddFirst()
        {
            _listwithTwoCount.AddFirst("zero");
            Assert.AreEqual(3,_listwithTwoCount.Count);
            Assert.AreEqual("zero",_listwithTwoCount.Head.Value);
            Assert.AreEqual("first",_listwithTwoCount.Head.Next.Value);
            Assert.AreEqual("second",_listwithTwoCount.Tail.Value);            
        }

        [TestMethod]
        public void ListwithTwoCount_AddLast()
        {
            _listwithTwoCount.AddLast("third");
            Assert.AreEqual(3,_listwithTwoCount.Count);
            Assert.AreEqual("first",_listwithTwoCount.Head.Value);
            Assert.AreEqual("second",_listwithTwoCount.Head.Next.Value);
            Assert.AreEqual("third",_listwithTwoCount.Tail.Value);            
        }
        
        [TestMethod]
        public void ListwithTwoCount_RemoveFirst()
        {
            _listwithTwoCount.RemoveFirst();
            Assert.AreEqual(1,_listwithTwoCount.Count);
            Assert.AreEqual("second",_listwithTwoCount.Head.Value);
            Assert.AreEqual("second",_listwithTwoCount.Tail.Value);
            Assert.AreEqual(_listwithTwoCount.Head,_listwithTwoCount.Tail);
        }
        

        [TestMethod]
        public void ListwithTwoCount_RemoveLast()
        {
            _listwithTwoCount.RemoveLast();
            Assert.AreEqual(1,_listwithTwoCount.Count);
            Assert.AreEqual("first",_listwithTwoCount.Head.Value);
            Assert.AreEqual("first",_listwithTwoCount.Tail.Value);
            Assert.AreEqual(_listwithTwoCount.Head,_listwithTwoCount.Tail);
        }


        [TestMethod]
        public void ListwithMorethanTwoCount_Remove()
        {
            _listwithMorethantwoCount.Remove("second");
            Assert.AreEqual(2,_listwithMorethantwoCount.Count);
            Assert.AreEqual("first",_listwithTwoCount.Head.Value);
            Assert.AreEqual("second",_listwithTwoCount.Tail.Value);
            
        }

        [TestInitialize]
        public void Setup()
        {
            _emptylist=new SingleLinkedList<string>();

            _listwithOneCount=new SingleLinkedList<string>();
            _listwithOneCount.Add("first");
            
            _listwithTwoCount=new SingleLinkedList<string>();
            _listwithTwoCount.Add("first");
            _listwithTwoCount.Add("second");


            _listwithMorethantwoCount=new SingleLinkedList<string>();
            _listwithMorethantwoCount.Add("first");
            _listwithMorethantwoCount.Add("second");
            _listwithMorethantwoCount.Add("third");

        }

        SingleLinkedList<string> _emptylist;  
        SingleLinkedList<string> _listwithOneCount;
        SingleLinkedList<string> _listwithTwoCount;
        SingleLinkedList<string> _listwithMorethantwoCount;
    }
}
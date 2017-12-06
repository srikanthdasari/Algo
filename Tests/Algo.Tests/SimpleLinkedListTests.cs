using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.LinkedList;
namespace Algo.Tests
{
    [TestClass]
    public class SimpleLinkedListTests
    {
        [TestMethod]
        public void SimpleLinkedListTests_Scenario1()
        {
            Assert.AreEqual("357",simpleLinkedList.BuildList());
        }


        [TestInitialize]
        public void Setup()
        {                
            simpleLinkedList=new SimpleLinkedList();       
        }

        private SimpleLinkedList simpleLinkedList;
    }
}

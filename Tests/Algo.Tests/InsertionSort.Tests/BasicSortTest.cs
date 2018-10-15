using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.InsertionSort;

namespace Algo.Tests.InsertionSort.Tests
{
    [TestClass]
    public class BasicSortTest
    {
        [TestMethod]
        public void BasicSortTest_DoSort_WithNUllInput()
        {
            var o=s.DoSort(null);
            Assert.IsNull(o);            
        }

        
        

        [TestMethod]
        public void BasicSortTest_DoSort_WithRepeatedInput() 
        {
            var o=s.DoSort(new int[] {3,1,4,2,6,5,11,5});
            Assert.IsNotNull(o);
            Assert.IsInstanceOfType(o,typeof(int[]));
            Assert.AreEqual(8,o.Length);
            Assert.AreEqual(o[0],1);
            Assert.AreEqual(o[1],2);
            Assert.AreEqual(o[2],3);
            Assert.AreEqual(o[3],4);
            Assert.AreEqual(o[4],5);
            Assert.AreEqual(o[5],5);
            Assert.AreEqual(o[6],6);
            Assert.AreEqual(o[7],11);
        }
        

        [TestInitialize]
        public void Setup()
        {
            s=new BasicSort();
        }   

        private BasicSort s; 
    }

    
}
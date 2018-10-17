using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.MergeSort;
namespace Algo.Tests.MergeSort.Tests
{
    [TestClass]
    public class BasicSortTest
    {
        
        [TestMethod]
        public void BasicSort_MergeSort_DoSort_WithNUllArray() {
            var o=t.DoSort(null,1,3,3);
            Assert.IsNull(o);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void BasicSort_MergeSort_DoSort_WithInvalidInput_Case1() {
            var o=t.DoSort(new int[]{1,4,2,3},2,1,1);        
            Assert.IsNull(o);            
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void BasicSort_MergeSort_DoSort_WithInvalidInput_Case2() {
            var o=t.DoSort(new int[]{1,4,2,3},1,2,1);        
            Assert.IsNull(o);    
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void BasicSort_MergeSort_DoSort_WithInvalidInput_Case3() {
            var o=t.DoSort(new int[]{1,4,2,3},0,0,1);            
            Assert.IsNull(o);
        }

        [TestMethod]        
        public void BasicSort_MergeSort_DoSort_WithvalidInput() {
            var o=t.DoSort(new int[]{2,4,5,7,1,2,3,6},0,3,8);            
            Assert.IsNotNull(o);
        }


        
        [TestInitialize]
        public void Setup() {
            t=new BasicSort();
        }

        public BasicSort t;
    }

}
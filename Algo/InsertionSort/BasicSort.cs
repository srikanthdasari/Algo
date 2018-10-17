using System;
using extensionlib;
namespace Algo.InsertionSort {
    public class BasicSort {
        public int[] DoSort (int[] array) {
            if (array.IsNull()) return null;
            
            for (var i=1;i<array.Length;i++) {
                var key = array[i]; // Current Card
                var j=i-1; 
                while(j>=0 && array[j]>key) {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1] = key;
            }
            return array;
        }
    }
}
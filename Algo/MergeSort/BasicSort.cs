using extensionlib;

namespace Algo.MergeSort
{
    public class BasicSort
    {
        
        // A : input array
        // p , q , r : indices (assume P is starting of the A[], Q is middle of the A[], R is the end of the A[] )
        // A[p..q..r]
        // p <= q < r
        // this procedure assumes that the subarrays A[p..q] and A[q+1, r] are in sorted order.
        // Finall Merged sorted array is A[p..r]
        public int[] DoSort(int[] A, int p, int q, int r) {

            if(A.IsNull()) return null;

            if(p>q) throw new System.Exception("Invalid Input");

            if(q>r) throw new System.Exception("Invalid Input");            

            var n1=q-p+1;               // Computes the n1 length of subarray A[p..q]
            var n2=r-q;                 // Computes the n2 length of subarray A[q+1..r]

            var L=new int[n1+1];        // Left Array of length n1+1
            var R=new int[n2+1];        // Right Array of length n2+1

            for(var i=1; i<=n1;i++)
                L[i]=A[p+i-1];          // Copies the subarray A[p..q] in to L[1..n1]

            for(var j=1;j<=n2;j++)
                R[j]=A[q+j];            // Copies the subarray A[q..r] in to R[1..n2]

            var a=0;
            var b=0;

            for(var c=p; c<=r;c++) {     // At the starting of each iteration of the for loop of lines the subarray A[p..k-1] 
                if(L[a]<=R[b]) {        // Contains the k-p smallest elements of L[1..n1+1] and R[1..n2+1] in sorted order
                    A[c]=L[a];          // Moreover L[i], R[J] are the smallest elements of their arrays that have not been copied back into A.
                    a++;
                } else  {
                    A[c]=R[b];
                    b++;
                }
            }

            return A;
        }
    }
}
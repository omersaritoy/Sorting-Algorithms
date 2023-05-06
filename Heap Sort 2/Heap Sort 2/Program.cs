using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random random=new Random();

            for(int i=0;i<arr.Length; i++)
                arr[i] = random.Next(0,100);

            // Function call
            printArray(arr);
            HeapSort ob = new HeapSort();
            ob.Sort(arr);


            Console.WriteLine("Sorted array is");
            
            printArray(arr);

            Console.ReadLine(); 
        }
        /* A utility function to print array of size n */
        static void printArray(int[] arr)
        {
            int N = arr.Length;
            for (int i = 0; i < N; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }
    }

    public class HeapSort
    {
        public void Sort(int[] arr)
        {
            int N = arr.Length;

            //build heap(rearrange array)

            for (int i = N / 2; i >= 0; i--)
                heapify(arr, N, i);

            //one by one extract an element from heap
            for (int i = N - 1; i > 0; i--)
            {   //Move current root to end    
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                //call max heapify on the reduced heap
                heapify(arr, i, 0);
            }

        }

        //to heapify a subtree rooted with node  i which is an Index in arr[].n is size of heap

        void heapify(int[] arr, int N, int i)
        {
            int largest = i;// Initialize largest as root
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            //if right child is larger  than largest so far
            if (left < N && arr[left] > arr[largest])
                largest = left;
            // If right child is larger than largest so far
            if (right < N && arr[right] > arr[largest])
                largest = right;

            //if largest is not root
            if (largest!=i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                //recursively hapify the affected sub-tree
                heapify(arr, N, largest);

            }

        }


    }
}

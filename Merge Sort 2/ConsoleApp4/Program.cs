using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int[] array = new int[8];
                Creat_Number(array);
                Write(array);
                Console.WriteLine("\n\n");
                sortMerge(array);
                Write(array);

                Console.ReadLine();
            }
            static void Creat_Number(int[] array)
            {
                Random random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 50);
                }
            }
            static void Write(int[] array)
            {
                foreach (var i in array)
                {
                    Console.Write(i + "\t");
                }
            }
        /*
         7 9 6 4 5 6 9 5

        7-9-6-4     5-6-9-5

     7-9      6-4          5-6        9-5

7  9      6  4      5  6    9  5

7-9      4-6     5-6     5-9

    4-6-7-9       5-5-6-9

        4-5-5-6-6-7-9

 */
        static void sortMerge(int[] array)
        {
            int inputLength = array.Length;

            if (inputLength < 2)
                return;

            int midIndex = inputLength / 2;
            int[] leftHalf = new int[midIndex];
            int[] rightHalf = new int[inputLength - midIndex];

            for (int i = 0; i < midIndex; i++)
            {
                leftHalf[i] = array[i];
            }

            for (int i = midIndex; i < inputLength; i++)
            {
                rightHalf[i - midIndex] = array[i];
            }

            sortMerge(leftHalf);
            sortMerge(rightHalf);
            Merge_sort(array, leftHalf, rightHalf);


        }

        static void Merge_sort(int[] array, int[] left, int[] right)
        {
            int leftsize = left.Length;
            int rightsize = right.Length;
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftsize && j < rightsize)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }

                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftsize)
            {
                array[k] = left[i];
                i++;
                k++;
            }
            while (j < rightsize)
            {
                array[k] = right[j];
                j++;
                k++;
            }

        }

    }
}

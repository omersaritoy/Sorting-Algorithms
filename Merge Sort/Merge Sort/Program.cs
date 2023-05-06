using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Creat_Number(array);
            Write(array);
            Console.WriteLine("\n\n");
            sortMerge(array, 0, array.Length - 1);
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

        static void sortMerge(int[] array, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                sortMerge(array, left, mid);
                sortMerge(array, (mid + 1), right);
                Merge_sort(array, left, (mid + 1), right);
            }
        }

        static void Merge_sort(int[] array, int left, int mid, int right)
        {
            int[] temp = new int[array.Length];
            int i, x, z, y;
            
            x = (mid - 1);
            y = left;
            z = (right - left + 1);

            while ((left <= x) && (mid <= right))
            {
                if (array[left] <= array[mid])

                    temp[y++] = array[left++];

                else
                    temp[y++] = array[mid++];
            }

            while (left <= x)

                temp[y++] = array[left++];


            while (mid <= right)

                temp[y++] = array[mid++];


            for (i = 0; i < z; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
    }
}

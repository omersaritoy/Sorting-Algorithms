using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort_Araya_Ekleme_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            CreateNumbers(array);
            Write(array);
            InsertionSort(array);
            Write(array);


            Console.ReadKey();
        }


        static void Write(int[] array)
        {
            foreach (var a in array)
            {
                Console.Write(a+"\t");
            }
        }

        static void CreateNumbers(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 50);
            }

        }

        private static void InsertionSort(int[] array)
        {
           /*
           for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j >0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            */

            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                int j=i-1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j+1]=array[j];
                    j--;
                }
                array[j + 1] = temp;
            }


            Console.WriteLine("\nSorted array of number is:");

        }
    }
}

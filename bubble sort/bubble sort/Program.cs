using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            
            
            Create_Number(Array);
            Write_Number(Array);
            Bubble_sort(Array);
            Console.WriteLine();
            Write_Number(Array);


            Console.ReadLine();
        }

        static void Create_Number(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 50);
            }
        }

        static void Write_Number(int[] array)
        {
            foreach (var i in array)
            {
                Console.Write(i + " \t");
            }
        }

        static void Bubble_sort(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[7];
            Create_Number(Array);
            Write_Numbers(Array);
            Selection_Sort(Array);
            Write_Numbers(Array);

            Console.ReadLine();
        }

        static void Create_Number(int[] array)
        {
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 50);
            }
        
        }
        
        static void Write_Numbers(int[] array)
        {
            foreach (var a in array)
            {
                Console.Write(a+"\t");
            }
        }

        static void Selection_Sort(int[] array)
        {
            int min,temp;
            for (int i = 0; i < array.Length-1; i++)
            {
                min = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            Console.WriteLine("\nSorted array of number is:");

        }

    }
}

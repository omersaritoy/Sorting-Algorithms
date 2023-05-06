using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_sort_1
{
    internal class Program
    {   /*
        1-pivot belirle
        2-ilem recuresive olarak devam edecek
        
        7 3 5 1 2       --> pivot(ortanca sayı=5)
        
        7 3 [5] 1 2

        2 3 [5] 1 7

        2 3 1 [5] 7

        2 [3] 1 
        
        2 1 [3] 
  
        [2] 1 

        1 [2] [3] [5]  [7] */
        
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Create_Number(array);
            Print_Array(array);
            quick_sort(array, 0, array.Length - 1);
            Print_Array(array);

            Console.ReadLine();
        }

        static void Create_Number(int[] array)
        {
            Random  random=new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(1, 100);
        }
        
        static void Print_Array(int[] array)
        {
            foreach (var item in array)
                Console.Write(item+"  ");
            Console.WriteLine();
        }
        
        static void quick_sort(int[] array,int leftstart,int rightend)
        {
            int i, j, pivot, temp;
            i = leftstart;
            j = rightend;
            pivot=array[(i+j)/2];

            do
            {
                while (array[i] < pivot)
                    i++;
                while (array[j] > pivot)
                    j--;

                if (i <= j)
                {
                    temp=array[i];  
                    array[i]=array[j];
                    array[j]=temp;
                    i++;
                    j--;
                }

            } while (i<j);

            if(i<rightend)
                quick_sort(array,i,rightend);
            if(leftstart<j)
                quick_sort(array,leftstart,j);

        }
    }
}

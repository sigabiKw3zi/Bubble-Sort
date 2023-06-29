using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 14, min = 1, max = 99;

            int[] array = new int[size];

            array = FillArray(size, min, max);
            
            Console.WriteLine("Unsorted Array");

            DisplayArray(array);

            Console.WriteLine("The array was sorted using Bubble sort");

            BubbleSort(array);
        }

        //static int[] FillArray(int size, int min, int max)
        //{
        //    int[] array = new int[size];
        //    int temp;
        //    bool found;

        //    Random random = new Random();

        //    for (int i = 0; i < size; i++)
        //    {
        //        do
        //        {
        //            temp = random.Next(min, max + 1);
        //            found = false;

        //            for (int j = 0; j < temp; j++)
        //            {
        //                found = true;
        //                j = i;
        //            }

        //            if (found == false)
        //                array[i] = temp;
        //        } while (found == true);

        //        return array;
        //    }
        //}

        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}]{1},", i, array[i]);
            }

            Console.WriteLine("[{0}]{1},", array.Length - 1, array[array.Length - 1]);
            
        }

        static void BubbleSort(int[] array)
        {
            int temp;

            for (int x = 0; x < array.Length; x++)
            {
                for(int i = 1; i < array.Length; i++)
                {
                    if(array[i - 1] > array[i])
                    {
                        temp = array[i-1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutreAlgorithm
{
    internal class BubbleSort
    {
        public static void Bubble()
        {
            int[] arr = { 78, 55, 98, 32, 99 };
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}

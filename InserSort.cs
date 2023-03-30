using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutreAlgorithm
{
    internal class InserSort
    {
        public void Display()
        {
            int[] arr = new int[5] { 20, 9, 30, 4, 50 };
            int n = 5, i, j, flag;
            Console.WriteLine("Before Sort");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("After Sort");
            for (i = 1; i < n; i++)
            {
                int val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }


            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}

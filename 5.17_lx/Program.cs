using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._17_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 冒泡排序

            //int[] number = new int[10]{20,5,17,28,19,15,29,87,65,32 };

            //for (int i = 0; i < number.Length-1; i++)
            //{
            //    for (int j = 0; j <number.Length-1-i; j++)
            //    {
            //        if (number[j]<number[j+1])
            //        {
            //            int temp = number[j];
            //            number[j] = number[j + 1];
            //            number[j + 1] = temp;
            //        }
            //    }
            //}

            #endregion


            #region 数组倒叙

            int[] arr = { 16,25,9,90,23};
            for (int i = 0; i <arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length-1-i];
                arr[arr.Length - 1 - i] = temp;
            }
            foreach (int item in arr)
            {
                Console.Write(item +" ");
            }
            Console.ReadKey();

            #endregion
        }
    }
}

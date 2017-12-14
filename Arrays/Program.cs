using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[500];
            //array[1] = 43;
            //int a = 15;

            //int[] array1 = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i <= 500; i++)
            //{              
            //    Console.WriteLine($"{array[i]}");
            //}                       

            byte[] arr = new byte[255];
            byte i;
            Random rand = new Random();
            //Console.WriteLine($"{rand.Next(0,15)}");
            for (i = 0; i < 255; i++)
            {
                arr[i] = (byte)rand.Next(0, 25);
                //Console.WriteLine(arr[i]);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
                if (item == 0)
                    break;
            }

            //byte[] arr1 = new byte[101];
            //byte j = 200;
            //for (byte i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = j;
            //    //Console.WriteLine(arr1[i]);
            //    j--;
            //}
            //foreach(var it in arr1)
            //    Console.WriteLine(it);


        }
    }
}

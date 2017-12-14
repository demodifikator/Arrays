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

            //byte[] arr = new byte[255];
            //byte i;
            //Random rand = new Random();
            ////Console.WriteLine($"{rand.Next(0,15)}");
            //for (i = 0; i < 255; i++)
            //{
            //    arr[i] = (byte)rand.Next(0, 25);
            //    //Console.WriteLine(arr[i]);
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //    if (item == 0)
            //        break;
            //}

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

            //string hw = "Hello world";
            //Console.WriteLine(hw[2]);

            //List<int> daysOfWeek = new List<int>();            
            //daysOfWeek.Add(1);
            //daysOfWeek.Add(2);
            //daysOfWeek.Add(3);
            //daysOfWeek.Add(4);
            //List<int> list2 = daysOfWeek;

            //foreach(var it in list2)
            //    Console.WriteLine(it);

            //Console.WriteLine(new string('-', 40));
            //daysOfWeek.Add(15);
            //foreach(var it in list2)
            //    Console.WriteLine(it);


            ////daysOfWeek.Add("Monday");
            ////daysOfWeek.Add("Tuesday");
            ////daysOfWeek.Add("Wednesday");
            //daysOfWeek.Add(1);

            //int h = 15;
            //object y = h;
            //h = 17;
            //Console.WriteLine(y);
            //foreach (var day in daysOfWeek)
            //{
            //    Console.WriteLine(day);
            //}


            //List<string> days = new List<string>
            //{
            //   "Monday", "Tuesday", "Wednesday",
            //   "Thursday", "Friday", "Saturday", "Sunday"
            //};
            ////days.Add("Monday");
            ////days.Add("Tuesday");
            ////days.Add("Wednesday");
            ////days.Add("Thursday");
            ////days.Add("Friday");
            ////days.Add("Saturday");
            ////days.Add("Sunday");
            //foreach(var day in days)
            //    Console.WriteLine(day);

            //int[,] arr = new int[5, 5];

            ////arr[0, 0] = 0;
            ////arr[0, 1] = 1;

            //for (int i =0; i<arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j<arr.GetLength(1);j++)
            //    {
            //        arr[i, j] = rand.Next(1, 15);                   
            //    }                
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i,j],2} ");
            //    }
            //    Console.WriteLine();
            //}

            Random rand = new Random();
            int[][] jagged = new int[2][];
            jagged[0] = new int[15];
            jagged[1] = new int[8];

            for (int i = 0; i<jagged.Length;i++)
            {
                for(int j = 0; j<jagged[i].Length; j++)
                {
                    jagged[i][j] = rand.Next(1, 10);       
                }         
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}

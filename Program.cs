using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArray;

            while (true)
            {                
                try
                {
                    Console.WriteLine("Enter size of the array: ");
                    lengthArray = int.Parse(Console.ReadLine());
                    if (lengthArray > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Array size must be positive integer!!!");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Array size must be positive integer!!!");
                }
            }

            int[] arr = new int[lengthArray];
            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Enter value of array[{i}]");
                        arr[i] = int.Parse(Console.ReadLine());

                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Value is not valid!!!");
                    }
                }
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            //Find largest element in array

            //THE FIRST WAY

            //if (arr[0] != arr[arr.Length-1])
            //{
            //    Console.WriteLine($"The largest number in the array is {arr[0]}");
            //}
            //else
            //{
            //    Console.WriteLine("Does not exist the number largest in array!");
            //}

            //THE SECOND WAY

            LargestNumberInArray(arr);


            //Find second largest element in array

            //if (arr[0] != arr[arr.Length - 1])
            //{
            //    Console.WriteLine($"The second largest number in the array is {arr[1]}");
            //}
            //else
            //{
            //    Console.WriteLine("Does not exist the number largest in array!");
            //}


            Console.ReadKey();
        }

        static void LargestNumberInArray(int[] arr)
        {
            //Array has the largest element

            int max = arr[0];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] > max)
                {
                    max = arr[i];
                }                
                else if(arr[i] != max)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"The largest number in the array is: {max}");
            }
            else
            {
                Console.WriteLine("Array does not exist with the largest number");                
            }
        }
    }
}

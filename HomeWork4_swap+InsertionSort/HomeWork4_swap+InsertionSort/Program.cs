using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Console.WriteLine("Please enter the size of your array");
            while (!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("You entered not a number. Please make sure to enter a number");
            }

            int[] array = new int[size];

            Console.WriteLine("Please Enter array values:");

            for (int i = 0; i < size; i++)
            {
                while (!Int32.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("You entered not a number for a value{0}. Please Enter again Value {0}", i);
                }
            }

            Console.WriteLine("Your array looks like this:");
            arrayout(array);

            int swap1 = 0;
            int swap2 = 0;
            Console.WriteLine("Please Enter first index of array value you want to swap.");
            while ((!Int32.TryParse(Console.ReadLine(), out swap1)) || swap1 < 0 || swap1 > array.Length - 1)
            {
                Console.WriteLine("Please Enter a number for the 1st index array value to swap. Make sure your numner is >= 0, and < {0}:", array.Length - 1);
            }
            Console.WriteLine("Please Enter second index of array value you want to swap:");
            while ((!Int32.TryParse(Console.ReadLine(), out swap2)) || swap2 < 0 || swap2 > array.Length - 1)
            {
                Console.WriteLine("Please Enter a number for the 2nd index array value to swap. Make sure your numner is >= 0, and < {0}:", array.Length - 1);
            }

            swap(array, swap1, swap2);

            Console.WriteLine("Your array after the swap:");
            arrayout(array);


            //Insertion Sort -------------------------------------------------------------------------------------------------------


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {

                    swap(array, i-1, i);

                    for (int j = (i - 1); j > 0; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            swap(array, j-1,j);
                        }

                        else
                        {
                            break;
                        }
                    }

                }

            }

            Console.WriteLine("Here is how your array looks like after the INSERTION sort:");
            arrayout(array);

            Console.ReadLine();

        }

  
        static void swap(int[] array, int swap1, int swap2)
        {
            int temp = 0;
            temp = array[swap1];
            array[swap1] = array[swap2];
            array[swap2] = temp;
        }


        static void arrayout(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(" " + array[i]);
            }
            Console.WriteLine(" ]");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_CircularBufferQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            int tail = 0;
            int head = 0;
            int count = 0;
            Console.WriteLine("Enter array size:");
            while(!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Please enter int");
            }

            int[] array = new int[size];
            int input = 0;
            int add = 0;
            

            while (input != 9)
            {
                Console.WriteLine("\n Please enter '1' to dequeue from the queue, or '2' to enqueue to the queue. Enter '9' to exit:");
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Please enter int");
                }

                if (input == 1)
                {
                    if (!isEmpty(array, head, tail, count))
                    {
                        Dequeue(array, ref head, ref tail, ref count);
                        queueOut(array, ref head, ref tail, count);
                        input = 0;
                    }

                    else 
                    {
                        Console.WriteLine("The queue is empty!!");
                    }
                }

                if (input == 2)
                {
                    if (!isFull(array, head, tail, count))
                    {
                        Console.WriteLine("Please enter value to enqueue:");
                        while (!Int32.TryParse(Console.ReadLine(), out add))
                        {
                            Console.WriteLine("Please enter int");
                        }
                        Enqueue(array, ref head, ref tail, add, ref count);
                        //arrayOut(array);
                        queueOut(array, ref head, ref tail, count);
                        input = 0;
                    }

                    else
                    {
                        Console.WriteLine("The queue is full!!");
                    }
                }

            }

            Console.WriteLine("you finished with the circular buffer queue manipulation. Thanks.");

            Console.ReadLine();
        }

        static void Enqueue(int[] array, ref int head, ref int tail, int add, ref int count)
        {

           
            array[head] = add;
            if (head < array.Length-1)
            {
                head = head + 1;
            }

            else
            {
                head = 0;
            }

            count = count + 1;
        }

        static void Dequeue(int[] array, ref int top, ref int tail, ref int count)
        {
            Console.WriteLine("Poped: " + array[tail]);

            if (tail < array.Length-1)
            {
                tail = tail + 1;
            }

            else
            {
                tail = 0;
            }

            count = count - 1;

        }

        static void queueOut(int[] array, ref int head, ref int tail, int count)
        {
            Console.WriteLine("Your queue looks like this now:");
            Console.Write("[");


            if (head > tail)
            {
                for (int i = tail; i < head; i++)
                {

                    Console.Write(" " + array[i] + " ");
                }
            }

            if (head<=tail & count !=0)
            {
                for (int i=tail; i<array.Length; i++)
                {
                    Console.Write(" " + array[i] + " ");
                }

                for (int i=0; i<head; i++)
                {
                    Console.Write(" " + array[i] + " ");
                }

               
            }
            if (head <= tail & count == 0)
            {
                
            }



            Console.Write("]");
        }

        static void arrayOut(int[] array)
        {
            Console.WriteLine("Your array looks like this:");
            Console.Write("[");
            for (int i = 0; i< array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }

        static bool isFull(int[] array, int head, int tail, int count)
        {
            if (head == tail & count != 0)
            {
                return true;
            }

           else 
            {
                return false;
            }
        }

        static bool isEmpty(int[] array, int head, int tail, int count)
        {
            if  (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

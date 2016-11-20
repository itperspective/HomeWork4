using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int top = 0;
            int size = 0;
            Console.WriteLine("Enter array size:");
            while (!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("enter int value");
            }

            

            int[] array = new int[size];

            arrayIn(array);
            arrayOut(array);

            top = array.Length - 1;

            string input = "";
            int push = 0;
            Console.WriteLine();


            while (input != "stop")
            {
                Console.WriteLine(" \n Pleasese press 'pop' to pop from stack, 'peek', or 'push' to push from stack, or 'stop' to quit:");
                input = Console.ReadLine().Trim();
                if (input == "peek")
                {
                    if (!isEmpty(array, top))
                    {
                        stackPeek(array, top);
                        stackOut(array, ref top);
                    }
                    else
                    {
                        Console.WriteLine("\n No peek. stack is empty");
                    }
                }
                if (input == "pop")
                {
                    if (!isEmpty(array, top))
                    {
                        stackPop(array, ref top);
                        stackOut(array, ref top);
                        input = "";
                    }
                    else
                    {
                        Console.WriteLine("\n Stack is empty!");
                    }
                }

                if (input == "push")
                {
                    //bool isFull1 = top == array.Length - 1 ? true : false;
                    if (!isFull(array,top))
                    {
                        Console.WriteLine("Please enter value to push to the stack:");
                        while (!Int32.TryParse(Console.ReadLine(), out push))
                        {
                            Console.WriteLine("Please neter int");
                        }
                        stackPush(array, ref top, push);
                        stackOut(array, ref top);
                        input = "";
                    }
                    else
                    {
                        Console.WriteLine("\n stack is full! can not push to the stack");
                    }
                }
            }


            stackOut(array, ref top);
            Console.ReadLine();
        }

        static void arrayIn(int[] array)
        {
            Console.WriteLine("Please enter array values:");
            for (int i=0; i<array.Length; i++)
            {
                while(!Int32.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Please enter int:");
                }
            }
        }
        static void arrayOut(int[] array)
        {
            Console.WriteLine("Your array looks like his:");
            Console.Write("[ ");
            for (int i=0; i<array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write(" ]");
        } 

        static void stackPop (int[] array, ref int top)
        {
            Console.WriteLine("Pop from stack:");
            Console.WriteLine(array[top]);
            top = top - 1;

        } 

        static void stackOut (int[] array, ref int top)
        {
            Console.WriteLine("Your stack looks like this now:");
            Console.Write("[");
            for (int i=0; i<top+1; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }

        static void stackPush (int[] array, ref int top, int push)
        {
            array[top + 1] = push;
            top = top + 1;
        }

        static void stackPeek (int[] array, int top)
        {
            Console.WriteLine(array[top]);
        }



        static bool isFull (int[] array, int top)
        {
            
            
            if(top == array.Length - 1)
            {
                return true;
            }
            else
           {
                return false;
            }

        }

        static bool isEmpty (int[] array, int top)
        {
            if (top == -1)
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

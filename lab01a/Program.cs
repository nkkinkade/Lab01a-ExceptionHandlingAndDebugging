using System;
using System.Runtime.InteropServices;

namespace lab01a
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Error!");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Program Completed");
            }
        }
        public static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero and the size of the array you want");
            string inputSizeArray = Console.ReadLine();
            int arrayNumber = Convert.ToInt32(inputSizeArray);
            int[] array = new int[arrayNumber];
            try
            {
                Populate(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Error!");
                Console.WriteLine(ex.Message);
            }

        }

        public static int[] Populate(int[] arrayofnumbers)
        {
            for (int i = 0; i < arrayofnumbers.Length; i++)
            {
                Console.WriteLine("Please enter a number: {0} of {1}", i + 1, arrayofnumbers.Length);
                string userInput = Console.ReadLine();
                arrayofnumbers[i] = Convert.ToInt32(userInput);
            }
            Console.WriteLine(String.Join(",", arrayofnumbers));
            return arrayofnumbers;
        }

        //pucblic static 
    }
    }


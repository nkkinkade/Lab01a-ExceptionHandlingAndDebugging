using System;

namespace Lab01a
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
                Console.WriteLine("Unhandled Error");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Program Completed");
            }

        }

        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int[] array = new int[number];

            try
            {
                int[] populatedArray = Populate(array);
                int arraySum = GetSum(populatedArray);
                int product = GetProduct(populatedArray, arraySum);
                decimal quotient = GetQuotient(product);

                Console.WriteLine("Your array size is: " + array.Length);
                Console.Write("The numbers in the array are: ");
                Console.WriteLine(String.Join(", ", array));
                Console.WriteLine("The sum of the array is " + arraySum);
                Console.WriteLine("{0} * {1} = {2}", arraySum, product / arraySum, product);
                Console.WriteLine("{0} / {1} = {2}", product, product / quotient, quotient);
            }

            catch (OverflowException oex)
            {
                Console.WriteLine("Overflow Exception");
                Console.WriteLine(oex.Message);
            }

            catch (IndexOutOfRangeException ioorex)
            {
                Console.WriteLine("Index Out Of Range Exception");
                Console.WriteLine(ioorex.Message);
            }
        }

        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int numberOf = i + 1;
                Console.WriteLine("Enter number " + numberOf + " of " + array.Length);
                string input = Console.ReadLine();
                int inputNumber = Convert.ToInt32(input);
                array[i] = inputNumber;
            }
            return array;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                sum = sum + number;
            }

            if (sum >= 20)
            {
                return sum;
            }

            else
            {
                throw new System.ArgumentOutOfRangeException("Value of " + sum + " is too low.");
            }
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Enter a number between 1 and {0}", array.Length - 1);
            string input = Console.ReadLine();
            int inputNumber = Convert.ToInt32(input);
            int product = 0;

            try
            {
                product = array[inputNumber] * sum;

            }

            catch (IndexOutOfRangeException ioex)
            {
                Console.WriteLine(ioex.Message);
            }

            return product;
        }

        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Enter a number to divide {product} by.");
            string input = Console.ReadLine();
            decimal inputNumber = Convert.ToDecimal(input);
            decimal decimalProduct = Convert.ToDecimal(product);
            decimal quotient;

            try
            {
                quotient = decimal.Divide(decimalProduct, inputNumber);
                return quotient;
            }

            catch (DivideByZeroException dbzex)
            {
                Console.WriteLine(dbzex.Message);
                return 0;
            }
        }
    }
}
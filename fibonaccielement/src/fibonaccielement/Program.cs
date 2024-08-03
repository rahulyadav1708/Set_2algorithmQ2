using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fibonaccielement
{
    public class Program
    {
        static void Main()
        {
            // Define the array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8,13 };

            // Find the Fibonacci numbers up to the maximum value in the array
            HashSet<int> fibonacciNumbers = GenerateFibonacciUpTo(array[array.Length - 1]);

            // Find the output by checking if the array elements are Fibonacci numbers
            int num = 0;
            foreach (int number in array)
            {
                if (fibonacciNumbers.Contains(number))
                {
                    num++;
                   Console.WriteLine(number);
                    
                    Console.ReadKey();
                }
               

            }
            Console.WriteLine("the longest sequence have "  + num + " element");
            Console.ReadKey();
        }

        static HashSet<int> GenerateFibonacciUpTo(int max)
        {
            HashSet<int> fibonacciNumbers = new HashSet<int>();
            int a = 0, b = 1;
            while (a <= max)
            {
                fibonacciNumbers.Add(a);
                int next = a + b;
                a = b;
                b = next;
            }
            return fibonacciNumbers;
        }
       

    }
   
}






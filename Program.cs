using System;

namespace dotnet_IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = 6;
            try
            {
                int value = numbers[index];
            
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Index is out of range");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a valid index:");
                index = int.Parse(Console.ReadLine());
                int value = numbers[index];
               
            }
        }
    }
}

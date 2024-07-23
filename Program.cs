using System;
using System.Collections.Generic;
namespace NavvTacAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(j - 1);
                }
                Console.WriteLine();
            }

            

            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(98);
            numbers.Add(67);
            numbers.Add(9);
            numbers.Add(45);
            numbers.Add(44);
            numbers.Add(23);
            numbers.Add(2);

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                Console.WriteLine(number);


            }
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                sum += numbers[i];

            }
            double average = (double)sum / numbers.Count;
            Console.WriteLine("Maximum Marks  " + max);
            Console.WriteLine("Minimum Marks  " + min);
            Console.WriteLine("Average Marks  " + average);
        }
    }
}

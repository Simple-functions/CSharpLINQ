﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ_Sum();
            //LINQ_Count();
            //LINQ_Average();
            //LINQ_Max();
            //LINQ_Min();
            //LINQ_Where();
            //LINQ_ConvertToList();
            //LINQ_CheckCondition();
            LINQ_CheckCondition2();
        }

        static void LINQ_Sum()
        {
            int[] numbers = { 1, 2, 3 };

            int sum = numbers.Sum();

            Console.WriteLine($"numbers 배열 요소의 합 : {sum}");
        }

        static void LINQ_Count()
        {
            int[] numbers = { 1, 2, 3 };

            int count = numbers.Count();

            Console.WriteLine($"numbers 배열 개수 : {count}");
        }

        static void LINQ_Average()
        {
            int[] numbers = { 1, 3, 4 };

            double average = numbers.Average();

            Console.WriteLine($"numbers 배열 요소의 평균 : {average:#,###.##}");
        }

        static void LINQ_Max()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };

            int max = numbers.Max();

            Console.WriteLine($"{nameof(numbers)} 컬렉션의 최대값 : {max}");
        }

        static void LINQ_Min()
        {
            List<double> numbers = new List<double>() { 3.3, 2.2, 1.1 };

            double min = numbers.Min();

            Console.WriteLine($"{nameof(numbers)} 리스트의 최소값 : {min:.00}");
        }

        static void LINQ_Where()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            IEnumerable<int> newNumbers = numbers.Where(number => number > 3);

            foreach(var n in newNumbers)
            {
                Console.WriteLine(n);
            }
        }

        static void LINQ_ConvertToList()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            List<int> newNumbers = numbers.Where(number => number > 3).ToList();

            foreach(var number in newNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void LINQ_CheckCondition()
        {
            List<int> numbers = new List<int> { 1, 2, 3 };

            int number = numbers.Where(n => n % 2 == 1).Sum();

            Console.WriteLine(number);
        }

        static void LINQ_CheckCondition2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            // 배열에서 홀수만 추출 : 람다 식 사용
            var query = arr.Where(num => num % 2 == 1);

            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }

    }
}

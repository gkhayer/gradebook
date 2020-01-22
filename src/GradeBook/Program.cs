using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott book");
            book.AddGrade(23.4);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stat = book.GetStatistics();
            
            Console.WriteLine($"highest number is {stat.High}");
            Console.WriteLine($"lowest number is {stat.Low}");
            Console.WriteLine($"Average is: {stat.Average}");
        }
    } 
}

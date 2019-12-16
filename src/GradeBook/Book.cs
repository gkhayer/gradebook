using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book 
    {
        public Book(string name){ 
            grades = new List<double>();
             
            this.name = name;
        }

        public void AddGrade(double grade) {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade =  double.MaxValue;
           
            foreach(var grade in grades){
                result += grade/(grades.Count);
                if(grade > highGrade){
                    highGrade = grade;
                }
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
            }
            Console.WriteLine($"highest number is {highGrade}");
            Console.WriteLine($"lowest number is {lowGrade}");
            Console.WriteLine($"Average is: {result:N1}");
        }
        
        // declaring outside the method become fields; inside its called variable
        private List<double> grades; 
        private string name;

    } 
}
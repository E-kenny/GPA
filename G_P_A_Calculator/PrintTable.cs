using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_P_A_Calculator
{
    public class PrintTable
    {
        List<Course> courses;

        public PrintTable(List<Course> courses)
        {
            this.courses = courses;
        }

        public List<Course> Courses
        {
            get { return courses; } 
            //set { courses = value; }
        } 

        public void Print()
        {
            //Print table
            Console.WriteLine($"|-----------------|----------------|---------------|---------------|--------------|---------------|\n|COURSE & CODE    |COURSE UNIT     |GRADE          |GRADE-UNIT     |WEIGHT PT     |REMARK         |\n|-----------------|----------------|---------------|---------------|--------------|---------------|");
            foreach (var course in courses)
            {
                Console.WriteLine($"|{course.CourseCode,-8}         |{course.CourseUnit,-5}           |{course.Grade,-5}          | {course.CourseGrade,-5}         |    {course.WeightPoint,-5}     |{course.Remark,-15}|\n");
            }
            Console.WriteLine($"|-----------------|----------------|---------------|---------------|--------------|---------------|");

            //GPA Object
            GPA calc = new GPA(courses);

            //Print Other results
            Console.WriteLine($"Total Course Unit = {calc.TotalCourseUnitRegistered}");
            Console.WriteLine($"Total Course Grade Unit = {calc.TotalGradeUnit}");
            Console.WriteLine($"Total Course Unit Passed = {calc.TotalUnitPassed}");
            Console.WriteLine($"Total Weight Point = {calc.TotalWeightPoint}");
            
            //GPA results
            Console.WriteLine($"GPA = {Math.Round(calc.Calculate(), 2)}");
        }
    }
}
  
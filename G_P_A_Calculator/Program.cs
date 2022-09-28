using G_P_A_Calculator;
using System;
namespace C_P_A_Calculator
{
   class Program
    {
        static void Main(string[] argv)
        {

            try
            {

                bool checker = true;
                bool courseCodeChecker = true;
                bool courseUnitChecker = true;
                bool scoreChecker = true;
                string courseCode = "";
                int courseUnit = 0;
                int score = 0;
                List<Course> courses = new List<Course>();

                while (checker)
                {


                    if (courseCodeChecker)
                    {
                        //Takes in the course code
                        Console.WriteLine("Please, Insert Course Code, input must not be less than eight(8)");
                        courseCode = Console.ReadLine();
                        if (courseCode.Length > 0 && courseCode.Length < 8)
                        {
                            courseCodeChecker = false;
                        }
                        else
                        {
                            Console.WriteLine("Re-type");
                            continue;
                        }
                    }

                    if (courseUnitChecker)
                    {
                        //Takes in the course unit
                        Console.WriteLine("Please, Insert Course Unit, input must be greater than 0 and not greater than 5 and must be an integer");

                        bool typeCheck = int.TryParse(Console.ReadLine(), out courseUnit);
                        if (typeCheck && courseUnit > 0 && courseUnit < 6)
                        {
                            courseUnitChecker = false;
                        }
                        else
                        {
                            Console.WriteLine("Re-type");
                            continue;
                        }
                    }
                    if (scoreChecker)
                    {
                        //Takes in the Score
                        Console.WriteLine("Please, Insert Course Score, , input must be greater than 0 and not greater than 100 and must be an integer");
                        bool typeCheck = int.TryParse(Console.ReadLine(), out score);
                        if (typeCheck && score > 0 && score < 101)
                        {
                            scoreChecker = false;
                        }
                        else
                        {
                            Console.WriteLine("Re-type");
                            continue;
                        }
                    }

                    //Add each course to the list
                    courses.Add(new Course(courseCode, courseUnit, score));

                    //ask for more course
                    Console.WriteLine("Do you want to add more course? type (Y or Yes) to add more or any button to continue");
                    string decision = Console.ReadLine();

                    if (!(decision.ToLower() == "y" || decision.ToLower() == "yes")) checker = false;

                }

                //Pass in the list of courses
                new PrintTable(courses).Print();

            }

            //Handle Exceptions
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }


}









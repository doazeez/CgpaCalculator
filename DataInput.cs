using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CgpaCalculator
{
    public class DataInput
    {
        public static void Entry()
        {
            List<CourseInput> CourseInputList = new List<CourseInput>();
            Console.WriteLine("\t\t\t\t***********WELLCOME TO DECAGON INSTITUTE************\n");
            Console.WriteLine("\t\t\t\t*************** GPA CALCULATOR***********\n");
            Console.WriteLine("Press Enter to Begin:\n");
            Console.ReadLine();
            int NumberOfCourse = 0;
            string courseCode;
            int courseUnit;
            int courseScore;

            Validation validation = new Validation();
            Console.WriteLine("Enter the number of Courses registered");
            string check = Console.ReadLine();
            while (Validation.numCheck(check) == "INVALID INPUT:")
            {
                Console.WriteLine(Validation.numCheck(check));
                Console.WriteLine("Invalid Input, Re-enter Number of registered Courses: ");
                check = Console.ReadLine();
            }
            NumberOfCourse = int.Parse(check);
           
            for (int k = 0; k < NumberOfCourse; k++)
            {
                Console.WriteLine("Enter the Course_name and code:");
                courseCode = Console.ReadLine().ToUpper();
                while (validation.isLetterOrDigit(courseCode) == false)
                {
                    Console.WriteLine("Wrong Format, Re-enter Course_name and code: with Format abc123 ");
                    courseCode = Console.ReadLine().ToUpper();
                }

                Console.WriteLine("Enter the Course unit:");
                string check1 = Console.ReadLine();
                while (Validation.numCheck(check1) == "INVALID INPUT" ||
                    Convert.ToInt32(Validation.numCheck(check1)) < 1 ||
                    Convert.ToInt32(Validation.numCheck(check1)) > 5)
                {
                    Console.WriteLine("Re-enter Course unit: Must be between 1-5");
                    check1 = Console.ReadLine();
                }
                courseUnit = int.Parse(check1);

                Console.WriteLine("Enter the Score:");
                string check2 = Console.ReadLine();
                while (Validation.numCheck(check2) == "INVALID INPUT" ||
                    Convert.ToInt32(Validation.numCheck(check2)) < 0 ||
                    Convert.ToInt32(Validation.numCheck(check2)) > 100)
                {
                    Console.WriteLine("Re-enter the score: Must be between 0-100");
                    check2 = Console.ReadLine();
                }
                courseScore = int.Parse(check2);

                if (courseScore >= 70 && courseScore <= 100)
                {
                    CourseInputList.Add(
                        new CourseInput
                        {
                            CourseCode = courseCode,
                            CourseUnit = courseUnit,
                            CourseScore = courseScore,
                            Grade = "A",
                            Remark = "Excellent",
                            GradePoint = 5
                        });


                }
                else if (courseScore >= 60 && courseScore <= 69)
                {
                    CourseInputList.Add(
                       new CourseInput
                       {
                           CourseCode = courseCode,
                           CourseUnit = courseUnit,
                           CourseScore = courseScore,
                           Grade = "B",
                           Remark = "Very Good",
                           GradePoint = 4
                       });
                }
                else if (courseScore >= 50 && courseScore <= 59)
                {
                    CourseInputList.Add(
                      new CourseInput
                      {
                          CourseCode = courseCode,
                          CourseUnit = courseUnit,
                          CourseScore = courseScore,
                          Grade = "C",
                          Remark = "Good    ",
                          GradePoint = 3,
                      });
                }
                else if (courseScore >= 45 && courseScore <= 49)
                {
                    CourseInputList.Add(
                         new CourseInput
                         {
                             CourseCode = courseCode,
                             CourseUnit = courseUnit,
                             CourseScore = courseScore,
                             Grade = "D",
                             Remark = "Fair    ",
                             GradePoint = 2,
                         });
                }
                else if (courseScore >= 40 && courseScore <= 44)
                {
                    CourseInputList.Add(
                      new CourseInput
                      {
                          CourseCode = courseCode,
                          CourseUnit = courseUnit,
                          CourseScore = courseScore,
                          Grade = "E",
                          Remark = "Pass    ",
                          GradePoint = 1,

                      });
                }
                    if (courseScore >= 0 && courseScore <= 39)
                    {
                        CourseInputList.Add(
                         new CourseInput
                         {

                             CourseCode = courseCode,
                             CourseUnit = courseUnit,
                             CourseScore = courseScore,
                             Grade = "F",
                             Remark = "Fail    ",
                             GradePoint = 0,

                         });
                    }
            }

            PrintTable.PrintingTable(CourseInputList);
                 
        }
    }
}

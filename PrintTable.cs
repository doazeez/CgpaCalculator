using System;
using System.Collections.Generic;
using System.Text;

namespace CgpaCalculator
{
    public class PrintTable
    {
        public static void PrintingTable(List<CourseInput> courseList)
        {
            double totalUnitRegistered = 0;
            double totalUnitPassed = 0;
            double weightPoint=0;
            double totalweightPoint = 0;
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("|Course_name\t|Course Unit\t|Score\t|Grade\t|Grade Point\t|Weight Point\t|Remark\t\t|");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            foreach (CourseInput course in courseList)
            {
                totalUnitRegistered += course.CourseUnit;
                if (course.Grade != "F")
                {
                    totalUnitPassed += course.CourseUnit;
                }
                weightPoint = course.CourseUnit * course.GradePoint;
                totalweightPoint += weightPoint;
                Console.WriteLine("|" + course.CourseCode + "\t\t|" + course.CourseUnit + "\t\t|" + course.CourseScore + "\t| " + course.Grade + "\t| " + course.GradePoint + "\t\t|" + weightPoint + "\t\t|" + course.Remark + "\t|");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------\n\n");
            double GPA = 0;
            GPA = (totalweightPoint) / (totalUnitRegistered);
            Console.WriteLine("\t\tTotal Number of Unit registered:" + " " + totalUnitRegistered);
            Console.WriteLine("\t\tTotal Number of Unit Passed:" + " " + totalUnitPassed);
            Console.WriteLine("\t\tTotal Number of Weight_Point:" + " " + totalweightPoint);
            Console.WriteLine("\t\t Grade Point Average (GPA):" + " " + Math.Round(GPA, 2));
            
        }
            
        


    }
}

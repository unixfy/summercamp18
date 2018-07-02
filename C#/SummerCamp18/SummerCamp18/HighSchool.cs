using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerCamp18
{
    class HighSchool : Student // Inherit some classes from Student.cs
    {
        //double sciGrade;

        //public double SciGrade
        //{
        //    get; set;
        //}

        double progGrade;

        public double ProgGrade
        {
            get; set;
        }

        public override string computeGPA()
        {
            string grade = "";

            double gpa = (0.2 * SportGrade + 0.2 * MathGrade + 0.2 * SciGrade + 0.2 * ProgGrade);

            if (gpa >= 90)
            {
                grade = "A";
            }
            else if (gpa >= 80)
            {
                grade = "B";
            }
            else if (gpa >= 70)
            {
                grade = "C";
            }
            else if (gpa >= 0)
            {
                grade = "Failure!";
            }

            return grade;
        }

        public override string ToString()
        {
            return "HIGH SCHOOL GRADE....\n\n\n\n\n" + "first name: " + FirstName + "\n last name: " + LastName + "\n student id: " + ID + "\n overall gpa: " + computeGPA().ToString();
        }
    }
}

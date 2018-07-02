using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerCamp18
{
    class ElementarySchool : Student
    {
        //string firstName; // Without "string xxx = xxx;" the string is by default private (same as "private string xxx = xxx")
        //public string FirstName
        //{
        //    get { return firstName; } // property 
        //    set { firstName = value; }
        //}
        //string lastName;
        //public string LastName
        //{
        //    get; set; // Same as what is used between the {} for FirstName
        //}

        //int id;
        //public int ID
        //{
        //    get; set; // Same as what is used between the {} for FirstName
        //}

        //double sportGrade;
        //public double SportGrade
        //{
        //    get; set; // Same as what is used between the {} for FirstName
        //}
        //double mathGrade;
        //public double MathGrade
        //{
        //    get; set; // Same as what is used between the {} for FirstName
        //}

        public override string computeGPA()
        {
            string grade = "";

            double gpa = (0.5 * SportGrade + 0.5 * MathGrade);

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
            return "ELEMENTARY SCHOOL GRADE....\n\n\n\n\n" +  "first name: " + FirstName + "\n last name: " + LastName + "\n student id: " + ID + "\n overall gpa: " + computeGPA().ToString();
        }
    }
}

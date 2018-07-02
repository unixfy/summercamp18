using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerCamp18
{
    public abstract class Student
    {
        string firstName; // Without "string xxx = xxx;" the string is by default private (same as "private string xxx = xxx")
        public string FirstName
        {
            get { return firstName; } // property 
            set { firstName = value; }
        }
        string lastName;
        public string LastName
        {
            get; set; // Same as what is used between the {} for FirstName
        }

        int id;
        public int ID
        {
            get; set; // Same as what is used between the {} for FirstName
        }

        double sportGrade;
        public double SportGrade
        {
            get; set; // Same as what is used between the {} for FirstName
        }
        double mathGrade;
        public double MathGrade
        {
            get; set; // Same as what is used between the {} for FirstName
        }
        double sciGrade;

        public double SciGrade
        {
            get; set;
        }

        public abstract string computeGPA();

        public abstract string ToString();
    }
}

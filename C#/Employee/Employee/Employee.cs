using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    abstract class Employee
    {
        // First Name
        string firstName;
        public string FirstName
        {
            get; set;
        }

        // Last Name 
        string lastName;
        public string LastName
        {
            get; set;
        }

        // Employee ID
        int id;
        public int ID
        {
            get; set;
        }

        // Employment Type
        string type;
        public string Type
        {
            get; set;
        }

        // Pay Rate
        double pay;
        public double Pay
        {
            get; set;
        }

        // Hours per Week
        int hours;
        public int Hours
        {
            get; set;
        }

        // Function to calculate the weekly salary (will be overridden in each individual class)
        public virtual double computeWeekly()
        {
            double sal = Pay * Hours;

            return sal;
        }

        // Function to calculate the bonus (will be overridden in each individual class)
        public abstract double computeBonus();

        // Need some function to print out the text into a messagebox
        public abstract string ToString();
    }
}

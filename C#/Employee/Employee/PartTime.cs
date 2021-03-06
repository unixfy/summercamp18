﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class PartTime : Employee
    {
        public override double computeBonus()
        {

            double bonus = 0.1 * computeWeekly();

            return bonus;
        }
        public override string ToString()
        {
            return "Welcome to Employee Info Viewer for part time employee\n\n\n" + 
                "First Name: " + FirstName + "\nLast Name: " + LastName + "\nEmployee ID: " + ID + 
                "\nEmployment Type: " + Type + "\nPay Rate: " + Pay + "\nWork Hours per Week: " + Hours + 
                "\nSalary: " + computeWeekly().ToString() + "\nBonus: " + computeBonus().ToString();
        }
    }
}

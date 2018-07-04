using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullTime ft = new FullTime()
            {
                FirstName = "John",
                LastName = "Doe",
                ID = 1,
                Type = "Programmer",
                Pay = 2,
                Hours = 50
            };

            MessageBox.Show(ft.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PartTime pt = new PartTime()
            {
                FirstName = "Bob",
                LastName = "John",
                ID = 2,
                Type = "CEO",
                Pay = 999999999,
                Hours = 1
            };

            MessageBox.Show(pt.ToString());
        }
    }
}

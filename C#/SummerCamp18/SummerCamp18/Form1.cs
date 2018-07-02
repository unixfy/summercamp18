using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummerCamp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElementarySchool ele = new ElementarySchool()
            {
                FirstName = "Alex",
                LastName = "Baker",
                ID = 1337,
                SportGrade = 0,
                MathGrade = 100

            };

            MessageBox.Show(ele.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MiddleSchool mss = new MiddleSchool()
            {
                FirstName = "Sam",
                LastName = "Mikle",
                ID = 56789,
                SportGrade = 100,
                MathGrade = 75,
                SciGrade = 75
            };

            MessageBox.Show(mss.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HighSchool hss = new HighSchool()
            {
                FirstName = "John",
                LastName = "Doe",
                ID = 12345,
                SportGrade = 0,
                MathGrade = 0,
                SciGrade = 500,
                ProgGrade = 500
            };

            MessageBox.Show(hss.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app was developed in Microsoft Visual Studio 2015 (because it's the only edition that is legally licensed....) at the Oakland University Adventures in Coding II summer camp 2018... Please check the GitHub repository for sources and maybe a little bit of commentating ;) \n© 2018 \n\nGitHub repo: https://github.com/unixfy/summercamp18");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // to track whose turnit is

        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // About Buttonw  wd
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is created by Unixfy at OU Adventures in Coding II summer camp 2018.\nGitHub Repo: https://github.com/unixfy/summercamp18 \n\n© 2018", "About Tic Tac Toe App");
        }

        // File > Close
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn) // If it's X's turn (turn == true) then change button text to X when clicked, otherwise O
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn; // to switch turn

            // Disable buttons that are already active (so O can't be changed to X)
            b.Enabled = false;

            turn_count++;

            check_win();


        }

        // Check if anyone won function
        private void check_win()
        {
            bool winner = false;
            // Horizontal win check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            // Vertical win check
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            // Diagonal win check
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                winner = true;

            if (winner)
            {
                disable_Buttons();

                string winner_player = "";
                if (turn)
                    winner_player = "O";
                else
                    winner_player = "X";
                MessageBox.Show(winner_player + " won! Congrats!", "Someone won.");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("The game is a draw.", "Alert");
            }
        }

        private void disable_Buttons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }// end of loop
            } // end of try
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true; // re-enable buttons
                    b.Text = "";
                }
            }
            catch { }
        }
    }
}

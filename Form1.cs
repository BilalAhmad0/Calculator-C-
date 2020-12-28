using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CALCULATOR : Form
    {
        float NUM1, NUM2, RESULT;
        char OPERATOR;
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void ONE_Click(object sender, EventArgs e)
        {
            Screen.Text += "1";
        }

        private void TWO_Click(object sender, EventArgs e)
        {
            Screen.Text += "2";
        }
        private void THREE_Click(object sender, EventArgs e)
        {
            Screen.Text += "3";
        }


        private void FOUR_Click(object sender, EventArgs e) {
            Screen.Text += "4";
        }

        private void FIVE_Click(object sender, EventArgs e)
        {
            Screen.Text += "5";
        }

        private void SIX_Click(object sender, EventArgs e)
        {
            Screen.Text += "6";
        }

        private void SEVEN_Click(object sender, EventArgs e)
        {
            Screen.Text += "7";
        }

        private void EIGHT_Click(object sender, EventArgs e)
        {
            Screen.Text += "8";
        }

        private void NINE_Click(object sender, EventArgs e)
        {
            Screen.Text += "9";
        }

        private void ZERO_Click(object sender, EventArgs e)
        {
            Screen.Text += "0";
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            NUM1 = Int32.Parse(Screen.Text);
            Screen.Text = "";
            OPERATOR = '+';
        }

        private void MULTIPLY_Click(object sender, EventArgs e)
        {
            NUM1 = Int32.Parse(Screen.Text);
            Screen.Text = "";
            OPERATOR = '*';

        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            NUM1 = Int32.Parse(Screen.Text);
            Screen.Text = "";
            OPERATOR = '-';

        }

        private void DIVIDE_Click(object sender, EventArgs e)
        {
            NUM1 = Int32.Parse(Screen.Text);
            Screen.Text = "";
            OPERATOR = '/';
        }

        private void MOD_Click(object sender, EventArgs e)
        {
            NUM1 = Int32.Parse(Screen.Text);
            Screen.Text = "";
            OPERATOR = '%';
        }

        private void BACKSPACE_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length > 0)
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1, 1);
        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            //Screen.Text = "";
            //Screen.Text += RESULT;
            NUM2 = Int32.Parse(Screen.Text);
            switch (OPERATOR)
            {
                case '+':
                    RESULT = NUM2 + NUM1;
                    break;
                case '-':
                    RESULT = NUM1 - NUM2;
                    break;
                case '*':
                    RESULT = NUM1 * NUM2;
                    break;
                case '/':
                    RESULT = NUM1 / NUM2;
                    break;
            }
            Screen.Text = "";
            Screen.Text = RESULT.ToString();
        }

      

        private void POINT_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
          //  Screen.Text.Remove(Nu);
        }

        private void Sin_Click(object sender, EventArgs e)
        {

        }
       

    }
}

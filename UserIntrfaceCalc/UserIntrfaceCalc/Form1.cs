using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserIntrfaceCalc.ServiceRef;

namespace UserIntrfaceCalc
{
    public partial class Form1 : Form
    {
        CalcServiceSoapClient Ref;
        public Form1()
        {
            InitializeComponent();
            Ref = new CalcServiceSoapClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParsingInput(textBox1.Text, textBox2.Text, '+');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParsingInput(textBox1.Text, textBox2.Text, '-');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParsingInput(textBox1.Text, textBox2.Text, '*');

        }
        private void button4_Click(object sender, EventArgs e)
        {
            ParsingInput(textBox1.Text, textBox2.Text, '/');

        }
        /**Logic of Consuming Service **/
        private void ParsingInput(String num1Asstring, String num2Asstring, char sign)
        {

            if (notValidInput(num1Asstring,num2Asstring))
            {
                MessageBox.Show("Please, Enter valid input");
                return;
            }

            int num1 = int.Parse(num1Asstring);
            int num2 = int.Parse(num2Asstring);

            if (sign == '+')
                textBox3.Text = (Ref.Addition(num1, num2)).ToString();
            else if (sign == '-')
                textBox3.Text = (Ref.Subtraction(num1, num2)).ToString();
            else if (sign == '*')
                textBox3.Text = (Ref.Multiplication(num1, num2)).ToString();
            else if (sign == '/' && num2 != 0)
                textBox3.Text = (Ref.Subtraction(num1, num2)).ToString();
            else
                MessageBox.Show("Cannot divide on Zero");
        }
        /** Check Validation **/
        private Boolean notValidInput(String num1Asstring, String num2Asstring)
        {
            if (String.IsNullOrWhiteSpace(num1Asstring) || String.IsNullOrEmpty(num2Asstring))
            {
                return true;
            }

            for (int i = 0; i < num1Asstring.Length; i++)
            {
                if (Char.IsLetter(num1Asstring[i])) return true;
            }

            for (int i = 0; i < num2Asstring.Length; i++)
            {
                if (Char.IsLetter(num2Asstring[i])) return true;
            }

            return false;
        }
    }
}

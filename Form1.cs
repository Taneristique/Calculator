using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorcalculator
{

    public partial class Form1 : Form
    {
       public Int32 num = 0;
       public Int32 num2 = 0;
       char sign = '+';
        public Form1()
        {
            InitializeComponent();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }


        private void button10_Click(object sender, EventArgs e)
        {
            // Convert text to long (assuming valid input)
            num2 = Convert.ToInt32(this.textBox1.Text);

            // Clear textbox
            this.textBox1.Text = "";

            switch (sign)
            {
                case '+':
                    Int32 result = add(num, num2);
                    // Update UI with the result (consider error handling)
                    this.textBox1.Text = result.ToString();
                    break;
                case '-':
                    Int32 difference = sub(num, num2);
                    this.textBox1.Text = difference.ToString();
                    break;
                case '*':
                    Int32 product = mul(num, num2);
                    this.textBox1.Text = product.ToString();
                    break;
                case '/':
                    // Check for division by zero
                    if (num2 == 0)
                    {
                        // Handle division by zero error (e.g., display message)
                        MessageBox.Show("Division by zero is not allowed!");
                    }
                    else
                    {
                        // Call Div function using long values
                        Double quotient = div(num, num2);
                        this.textBox1.Text = quotient.ToString();
                    }
                    break;
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Taneristique Calculator";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "=";
            button10.Font = new Font(this.button10.Font.FontFamily, 20);
            button11.Text = "+";
            button11.Font = new Font(this.button11.Font.FontFamily, 20);
            button12.Text = "-";
            button12.Font = new Font(this.button12.Font.FontFamily, 20);
            button13.Text = "*";
            button13.Font = new Font(this.button13.Font.FontFamily, 20);
            button14.Text = "/";
            button14.Font = new Font(this.button14.Font.FontFamily, 20);
            button14.Font = new Font(this.textBox1.Font.FontFamily, 20);
            button15.Text = "C";
            button15.Font = new Font(this.button15.Font.FontFamily, 20);
            button15.ForeColor = Color.Red;
            textBox1.Font = new Font(this.textBox1.Font.FontFamily, 50);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(this.textBox1.Text);
            this.textBox1.Text = "";
            sign = '*';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(this.textBox1.Text); 
            this.textBox1.Text = "";
            sign = '/';

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(this.textBox1.Text);
            this.textBox1.Text = "";
            sign = '+';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(this.textBox1.Text);
            this.textBox1.Text = "";
            sign = '-';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num = 0;
            this.textBox1.Text = "0";
        }
    }
}

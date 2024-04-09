using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BMI_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void uSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weight, Height, Result;
            string Result2;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter the values for both Height and Weight", "Error");
                button3_Click(sender, e);
            }
            else if (textBox1.Text == "0" || textBox2.Text == "0")
            {
                MessageBox.Show("Entered values can't be zero.", "Error");
                button3_Click(sender, e);
            }
            else
            {
                Weight = Convert.ToDouble(textBox1.Text);
                Height = Convert.ToDouble(textBox2.Text) / 100;
                Result = 0;

                if (radioButton1.Checked)
                {
                    Result = Weight / (Height * Height);
                }
                else if (radioButton2.Checked)
                {
                    Result = (Weight / 2.205) / (Height * Height);
                }

                if (Result < 16)
                {
                    Result2 = "You are Underweight(Severe thinness)";
                }
                else if (Result <= 16.9 && Result >= 16)
                {
                    Result2 = "You are Underweight(Moderate thinness)";
                }
                else if (Result <= 18.4 && Result >= 17)
                {
                    Result2 = "You are Underweight(Mild thinness)";
                }
                else if (Result <= 24.9 && Result >= 18.5)
                {
                    Result2 = "You are Normal";
                }
                else if (Result <= 29.9 && Result >= 25)
                {
                    Result2 = "You are Overweight(Pre - obese)";
                }
                else if (Result <= 34.9 && Result >= 30)
                {
                    Result2 = "You are Obese(Class I)";
                }
                else if (Result <= 39.9 && Result >= 35)
                {
                    Result2 = "You are Obese(Class II)";
                }
                else
                {
                    Result2 = "You are Obese(Class III)";
                }

                /*Underweight(Severe thinness) < 16.0
                Underweight(Moderate thinness) 16.0 – 16.9 
                Underweight(Mild thinness) 17.0 – 18.4
                Normal range    18.5 – 24.9
                Overweight(Pre - obese)  25.0 – 29.9
                Obese(Class I) 30.0 – 34.9
                Obese(Class II)    35.0 – 39.9
                Obese(Class III)   ≥ 40.0*/

                if (!radioButton2.Checked && !radioButton1.Checked)
                {
                    MessageBox.Show("Please select either Kilogram or Pound", "Error");
                    button3_Click(sender, e);
                }
                else
                {
                    textBox3.Text = "Your BMI is: " + Result.ToString("#.#") + "\r\n" + Result2;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 firstForm;
            firstForm = new Form1();
            firstForm.Show();

            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

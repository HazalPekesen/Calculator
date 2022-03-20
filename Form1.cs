using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    public partial class Form1 : Form
    {
        string operation;
        double firstNumber, secondNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textbox için readonly: true yapıldı!            
        }

        #region her buton için özel bir click eventi tanımlandı
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        #endregion       

        #region keypress özelliği verildi.
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;    //form1 için keypreview özelliği true yapıldı.
            if (karakter == '1')
            {
                textBox1.Text = textBox1.Text + "1";
            }
            if (karakter == '2')
            {
                textBox1.Text = textBox1.Text + "2";
            }
            if (karakter == '3')
            {
                textBox1.Text = textBox1.Text + "3";
            }
            if (karakter == '4')
            {
                textBox1.Text = textBox1.Text + "4";
            }
            if (karakter == '5')
            {
                textBox1.Text = textBox1.Text + "5";
            }
            if (karakter == '6')
            {
                textBox1.Text = textBox1.Text + "6";
            }
            if (karakter == '7')
            {
                textBox1.Text = textBox1.Text + "7";
            }
            if (karakter == '8')
            {
                textBox1.Text = textBox1.Text + "8";
            }
            if (karakter == '9')
            {
                textBox1.Text = textBox1.Text + "9";
            }
            if (karakter == '0')
            {
                textBox1.Text = textBox1.Text + "0";
            }
            if (karakter == '/')
            {
                textBox1.Text = textBox1.Text + "/";
            }
            if (karakter == 'x')
            {
                textBox1.Text = textBox1.Text + "x";
            }
            if (karakter == '-')
            {
                textBox1.Text = textBox1.Text + "-";
            }
            if (karakter == '+')
            {
                textBox1.Text = textBox1.Text + "+";
            }
            if (karakter == ',')
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
        #endregion

        private void button18_Click(object sender, EventArgs e)  //C butonu
        {
            textBox1.Text = null;
        }

        private void button10_Click(object sender, EventArgs e)  // / butonu
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "/";
            //textBox1.Text = null;
            //operation = "/";
        }

        private void button11_Click(object sender, EventArgs e)  // x butonu
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = null;
            textBox1.ResetText();
            operation = "x";
            //textBox1.Text = textBox1.Text + "x";
        }

        private void button12_Click(object sender, EventArgs e)  // - butonu
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "-";
        }

        private void button13_Click(object sender, EventArgs e)  // + butonu
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "+";
        }

        private void button17_Click(object sender, EventArgs e)  // , butonu
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button14_Click(object sender, EventArgs e)  // AVG butonu
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "AVG";
        }

        private void button16_Click(object sender, EventArgs e)  // = butonu
        {
            switch (operation)
            {
                case "+":
                    secondNumber = Convert.ToInt32(textBox1.Text);
                    textBox1.ResetText();
                    textBox1.Text = Convert.ToString(firstNumber + secondNumber);
                    //result = (firstNumber + secondNumber);
                    //textBox1.Text = Convert.ToString(result);
                    //firstNumber = result;
                    break;
                case "-":
                    secondNumber = Convert.ToInt32(textBox1.Text);
                    textBox1.ResetText();
                    textBox1.Text = Convert.ToString(firstNumber - secondNumber);
                    break;
                case "x":
                    secondNumber = Convert.ToInt32(textBox1.Text);
                    textBox1.ResetText();
                    textBox1.Text = Convert.ToString(firstNumber * secondNumber);
                    break;
                case "/":
                    secondNumber = Convert.ToInt32(textBox1.Text);
                    textBox1.ResetText();
                    textBox1.Text = Convert.ToString(firstNumber / secondNumber);
                    if (secondNumber == 0)
                    {
                        textBox1.Text = "ERROR";
                    }
                    break;
                case "AVG":
                    secondNumber = Convert.ToDouble(textBox1.Text);
                    textBox1.ResetText();
                    textBox1.Text = Convert.ToString((firstNumber + secondNumber) / 2);
                    break;
            }
        }
    }
}


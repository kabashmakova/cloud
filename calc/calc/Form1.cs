using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace calc
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, b;
        int count;
        bool znak = true;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void bp_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void bdel_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    if (float.Parse(textBox1.Text) == 0) {
                        textBox1.Text = "На ноль делить нельзя!";
                        label1.Text = "";
                        break;
                            }
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        double res,a1;

        private void calculate2()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox2.Text);
                    if (float.Parse(textBox2.Text) == 0)
                    {
                        textBox2.Text = "На ноль делить нельзя!";
                        label5.Text = "";
                        break;
                    }
                    textBox2.Text = b.ToString();
                    break;
                case 5:
                    res = Math.Sin(a1);
                    textBox2.Text = res.ToString();
                    break;
                case 6:
                    res = Math.Cos(a1);
                    textBox2.Text = res.ToString();
                    break;
                case 7:
                    res = Math.Tan(a1);
                    textBox2.Text = res.ToString();
                    break;
                case 8:
                    res = Math.Sqrt(a1);
                    textBox2.Text = res.ToString();
                    break;
                case 9:
                    res = Math.Pow(a1,2);
                    textBox2.Text = res.ToString();
                    break;
                default:
                    break;
            }

        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculate2();
            label5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 1;
            label5.Text = a.ToString() + "+";
            znak = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 2;
            label5.Text = a.ToString() + "-";
            znak = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 3;
            label5.Text = a.ToString() + "*";
            znak = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 4;
            label5.Text = a.ToString() + "/";
            znak = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(textBox2.Text);
            textBox2.Clear();
            count = 5;
            label5.Text = "sin(" + a1.ToString() + ")";
            znak = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(textBox2.Text);
            textBox2.Clear();
            count = 7;
            label5.Text = "cos(" + a1.ToString() + ")";
            znak = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(textBox2.Text);
            textBox2.Clear();
            count = 8;
            label5.Text = "√(" + a1.ToString() + ")";
            znak = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(textBox2.Text);
            textBox2.Clear();
            count = 9;
            label5.Text = "(" + a1.ToString() + ")²";
            znak = true;
        }

        private void be_Click(object sender, EventArgs e)
        {
            calculate();
            label5.Text = "";
        }
    }
}

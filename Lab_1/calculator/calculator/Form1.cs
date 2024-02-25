using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
        bool OpFlag = false,success=true;
        int opr = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text+ "1";
        }
        //write only for 2 buttons 
        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void CC_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
            OpFlag = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (OpFlag == false)
            {
                textBox1.Text = textBox1.Text + "+";
                OpFlag = true;
                opr = 1;
            }
            else
            {
                MessageBox.Show("Only one operator at a given time");
            }
            
        }
        // write only for division

        private void minus_Click(object sender, EventArgs e)
        {
            if (OpFlag == false)
            {
                textBox1.Text = textBox1.Text + "-";
                OpFlag = true;
                opr = 2;
            }
            else
            {
                MessageBox.Show("Only one operator at a given time");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (OpFlag == false)
            {
                textBox1.Text = textBox1.Text + "*";
                OpFlag = true;
                opr = 3;
            }
            else
            {
                MessageBox.Show("Only one operator at a given time");
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (OpFlag == false)
            {
                textBox1.Text = textBox1.Text + "/";
                OpFlag = true;
                opr = 4;
            }
            else
            {
                MessageBox.Show("Only one operator at a given time");
            }
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3.14";
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text);
            result = Math.Sin(result);
            textBox1.Text = result.ToString();
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text);
            result = Math.Cos(result);
            textBox1.Text = result.ToString();
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text);
            result = Math.Tan(result);
            textBox1.Text = result.ToString();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            char[] operators = { '+', '-', '*', '/' };
            string[] parts = expression.Split(operators, StringSplitOptions.RemoveEmptyEntries);
            float result = 0;
            switch(opr)
            {
                case 1:
                    result = float.Parse(parts[0]) + float.Parse(parts[1]);
                    success = true;
                    break;
                case 2:
                    result = float.Parse(parts[0]) - float.Parse(parts[1]);
                    success = true;
                    break;
                case 3:
                    result = float.Parse(parts[0]) * float.Parse(parts[1]);
                    success = true;
                    break;
                case 4:
                    if (float.Parse(parts[1])==0)
                    {
                        MessageBox.Show("Error:Divide by Zero");
                        break;
                    }
                    result = float.Parse(parts[0]) / float.Parse(parts[1]);
                    success = true;
                    break;
                default:
                    {
                    success = false;
                    
                    break;
                    }
            }
            if(success)
            {
                textBox1.Text = ""+result;
                OpFlag = false;
            }
            else
            {
                MessageBox.Show("Invalid Expression,Retry?");
            }
            

        }
        //write the 4 scientific expressions and equal to ka code
        //output=Window

        //Q2 don't write import statement
        //write everything else
        //highlight which component you have used(1 for each type)

        //LAB2
        //Q1
        //not import
        //everything else
        //output:UI with all the options of menu box

        //Q2
        //Should show all the forms need not highlight only highlight if new component used


    }
}

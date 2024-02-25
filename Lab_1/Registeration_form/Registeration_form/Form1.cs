using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registeration_form
{
    public partial class Form1 : Form
    {
        String output;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Boolean radio_flag = false,reg_flag=false,year_flag=false;
            output = "Registeration Succesful\n";
            output = output+"Hi "+textBox1.Text+"\n";
            if (numericUpDown1.Value <= 1000 && numericUpDown1.Value > 0)
            {
                reg_flag = true;
                output = output + "Registeration Number: " + numericUpDown1.Value+"\n";
            }

            if (radioButton1.Checked == true)
            {
                output = output + radioButton1.Text;
                radio_flag = true;
            }
            
            if (radioButton2.Checked == true)
            {
                output = output + radioButton2.Text;
                radio_flag = true;
            }
            if (radioButton3.Checked == true)
            {
                output = output + radioButton3.Text;
                radio_flag = true;
            }
            if (comboBox1.SelectedIndex != -1)
            {
                year_flag = true;
                output = output + "\nYear:"+comboBox1.SelectedItem;
            }


            if (textBox1.Text != "" && radio_flag && reg_flag && year_flag)
            {
                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("Registeration Unsuccesful.\nIncomplete input.");
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value=0 ;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            comboBox1.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

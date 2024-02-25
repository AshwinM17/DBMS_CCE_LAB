using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Form2 : Form
    {
        Form3 ob;
        public string[] transaction = new string[5];
        public string AcNo;
        public double balance = 10000000;
        DateTime lastAccess = DateTime.Now;
        public Form2(string AcNo)
        {
            this.AcNo = AcNo;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameLabel.Text ="Ashwin Mittal";
            balancelabel.Text = "$" + balance.ToString();
            accessLabel.Text = lastAccess.ToString();
            transLabel.Text = "$0";
            ob = new Form3(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void transbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ob.Show();
        }
        public void updateTransaction()
        {
            string transactionString = string.Empty;
            for (int i = 0; i < transaction.Length; i++)
            {
                transactionString += transaction[i] + "\n";
            }
            transLabel.Text = transactionString;
            balancelabel.Text = "$" + balance.ToString();
        }
    }
}

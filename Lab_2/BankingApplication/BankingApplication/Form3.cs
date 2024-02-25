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
    public partial class Form3 : Form
    {
        Form2 obj;
        public Form3(Form2 obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void updateTransaction(double currentTransaction)
        {
            for (int i = obj.transaction.Length - 1; i > 0; i--)
            {
                obj.transaction[i] = obj.transaction[i - 1];
            }
            obj.transaction[0] = "Deposited $" + currentTransaction.ToString()+" to " +Benificiary.Text;
            obj.balance = obj.balance - currentTransaction;
        }

        private void Details_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj.Show();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double currentTransaction;
            Double.TryParse(amount.Text, out currentTransaction);
            if (obj.balance - currentTransaction > 0)
            {
                updateTransaction(currentTransaction);
                obj.updateTransaction();
                MessageBox.Show("Transaction Successful");
            }
            else
            {
                MessageBox.Show("Insufficient Balance");
            }
            Benificiary.Text = string.Empty;
            amount.Text = string.Empty;
        }
    }
}

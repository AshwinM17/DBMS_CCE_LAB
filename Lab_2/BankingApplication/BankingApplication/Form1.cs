namespace BankingApplication
{
    public partial class Form1 : Form
    {
        private string AcNo = "1234";
        private string pass = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Username.Text == AcNo && Password.Text == pass)
            {
                Form2 ob = new Form2(AcNo);
                this.Hide();
                ob.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Account Number or Password");
            }
        }

        private void forgot_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            Changepass.Visible = true;


        }

        private void Changepass_Click(object sender, EventArgs e)
        {
            pass = textBox1.Text;
        }
    }
}

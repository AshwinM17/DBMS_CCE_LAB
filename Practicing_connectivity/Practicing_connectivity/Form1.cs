using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;//
using Oracle.DataAccess.Types;//


namespace Practicing_connectivity
{
    public partial class Form1 : Form
    {
        OracleConnection conn;//
        OracleCommand comm;//
        OracleDataAdapter da;//
        DataSet ds;//
        DataTable dt;//
        DataRow dr;//
        int i=0;
        public Form1()
        {
            InitializeComponent();
        }
        public void connect1()//
        {
            String oradb = "Data Source=172.16.54.24:1521/ictorcl;User ID=cce128;Password=student";
            conn = new OracleConnection(oradb); // C# 
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//
        {
            connect1();
            comm = new OracleCommand(); 
            comm.CommandText = "select * from person";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "person");
            dt = ds.Tables["person"];
            int t = dt.Rows.Count;
            MessageBox.Show("Number of tuples:" + t.ToString());//gives the number of tuples
            dr = dt.Rows[i];
            textBox1.Text = dr["driver_id#"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["address"].ToString();
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

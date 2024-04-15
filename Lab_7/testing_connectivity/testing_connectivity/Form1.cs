using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace testing_connectivity
{
    public partial class Form1 : Form
    {
        OracleConnection conn;//
        OracleCommand comm;//
        OracleDataAdapter da;//
        DataSet ds;//
        DataTable dt;//
        DataRow dr;//
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            String oradb = "Data Source=172.16.54.24:1521/ictorcl;User ID=cce128;Password=student";
            conn = new OracleConnection(oradb); // C# 
            conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //connect and fetch 1st tuple
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from person";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();   
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "person");
            dt = ds.Tables["person"];
            int t = dt.Rows.Count;
            MessageBox.Show("Number of tuples:"+t.ToString());
            dr = dt.Rows[i];
            textBox1.Text = dr["driver_id#"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["address"].ToString();
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
    
            i++;
            if (i >= dt.Rows.Count) 
                i = 0;
            dr = dt.Rows[i];
            textBox1.Text = dr["driver_id#"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["address"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox1.Text = dr["driver_id#"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["address"].ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //insert
            connect1();
            OracleCommand cm = new OracleCommand(); 
            cm.Connection = conn;
            cm.CommandText = "insert into person values('" + textBox1.Text +"', '"+textBox2.Text+"','"+textBox3.Text+"')";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery(); 
            MessageBox.Show("Inserted!");
            conn.Close();
        }

        //update into table
        private void button5_Click(object sender, EventArgs e)
        {
            connect1();
            int v = int.Parse(textBox2.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update instructor set salary=:pb where deptname =:pdn";
            cm.CommandType = CommandType.Text;
            //Uses OracleParameter to read the parameter from the GUI 
            OracleParameter pa1 = new OracleParameter();
            pa1.ParameterName = "pb";
            pa1.DbType = DbType.Int32;
            pa1.Value = v;
            OracleParameter pa2 = new OracleParameter();
            pa2.ParameterName = "pdn";
            pa2.DbType = DbType.String;
            pa2.Value = textBox1.Text;
            cm.Parameters.Add(pa1);
            cm.Parameters.Add(pa2); 
            cm.ExecuteNonQuery();
            MessageBox.Show("updated");
            conn.Close();
            
        }
    }
}*/
function:
 create or replace function name(param)
 return type
 as 
 variables

 begin

 loop
    i:=i+2;
    exit when i>10;
 end loop;
for i in 1..10 loop

end loop;
while if<10 loop
i:=i+2
end loop;

end:
/

--anonymous
set serveroutput on
    declare
    
    begin
        dbms_output.put_line('hi'||1);

    end;
/

--procedure
set serveroutput on
create or replace procedure procq()








  
  
  

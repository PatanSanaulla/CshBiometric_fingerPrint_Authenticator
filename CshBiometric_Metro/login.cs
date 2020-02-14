using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CshBiometric_Metro
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\sameena\documents\visual studio 2010\Projects\CshBiometric_Metro\CshBiometric_Metro\database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LOGIN where userid='" + textBox1.Text + "' AND password='" + textBox2.Text + "';",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainForm strt = new MainForm();
                strt.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid details");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CshBiometric_Metro
{
    public partial class passengerinfo : Form
    {
        string imglocation=null;
        string imglocation1=null;

        public passengerinfo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
               imglocation = openflg.FileName.ToString();
               PictureBox1.ImageLocation = imglocation;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                imglocation1 = openflg.FileName.ToString();
                PictureBox2.ImageLocation = imglocation1;
            }
                
        }

        public class noimageException : Exception
        {
            public noimageException(string message) : base(message)
            {
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
            if(imglocation == null || imglocation1 == null)
            { throw (new noimageException("Please Select both the images")); }
            else
            {
            byte[] images = null;
            FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            byte[] images1 = null;
            FileStream Stream1 = new FileStream(imglocation1, FileMode.Open, FileAccess.Read);
            BinaryReader brs1 = new BinaryReader(Stream1);
            images1 = brs1.ReadBytes((int)Stream1.Length);

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\sameena\documents\visual studio 2010\Projects\CshBiometric_Metro\CshBiometric_Metro\database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into passengers values ('" + nametb.Text + "','" + uidtb.Text + "','" + addresstb.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + TextBox5.Text + "',@images,@images1,'"+imglocation1+"')", con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.Parameters.Add(new SqlParameter("@images1", images1));
            int N = cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(N.ToString()+"successfully entered details");
            this.Hide();
            }
            }
            catch( noimageException f)
            { MessageBox.Show("Please selcct the images");            }
            
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Amountopay = 0;
            if (ComboBox3.Text == "One ride")
            { TextBox5.Text="40/-"; }
            else
                if (ComboBox3.Text == "1 Month")
                { TextBox5.Text = "1000/-"; }
                else
                    if (ComboBox3.Text == "6 Months")
                    { TextBox5.Text = "6000/-"; }
                    else
                    { TextBox5.Text = "8000/-"; ; }
        }
        
    }
}

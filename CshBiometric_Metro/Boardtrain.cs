using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace CshBiometric_Metro
{
    public partial class Boardtrain : Form
    {
        Bitmap bitmap1,bitmap2;
        public Boardtrain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.ImageLocation = openflg.FileName;
                bitmap1 = new Bitmap(openflg.FileName);

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MemoryStream ms = new MemoryStream();
            //bitmap1.Save(ms, ImageFormat.Png);
            //string firstbitmap = Convert.ToBase64String(ms.ToArray());
            //
            string name=null, board=null, aadhar=null;
            bool compare =false;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\sameena\documents\visual studio 2010\Projects\CshBiometric_Metro\CshBiometric_Metro\database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand myCommand = new SqlCommand("select fullName,boardpt,fingerprint,fpadd,aadhar from passengers", con);
            SqlDataReader dataread = myCommand.ExecuteReader();
            //dataread.Read();

            while (dataread.Read()) //.HasRows
            {
                name = dataread[0].ToString();
                board = dataread[1].ToString();
                byte[] images = ((byte[])dataread[2]);
                string fpadd = dataread[3].ToString();
                aadhar = dataread[4].ToString();

                if (images == null) { MessageBox.Show("no match found"); }
                else
                {
                    bitmap2 = new Bitmap(fpadd);
                    compare = ImageCompareString(bitmap1, bitmap2);
                    if (compare == true)
                    {
                        dataread.Close();
                        myCommand.Cancel();
                        MessageBox.Show("welcome Aboard, " + name);
                        break;
                    }
                }   
                
            }
            if (compare == true)
            {
                SqlCommand cmd = new SqlCommand("insert into Entry values ('" + aadhar + "','" + name + "','" + board + "',GETDATE(),GETDATE())", con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
            }
            else
            {
                con.Close();
                this.Hide();
                MessageBox.Show("Not Match");
            }
        }

                           
        private bool ImageCompareString(Bitmap bitmap11, Bitmap bitmap21)
        {
            MemoryStream ms = new MemoryStream();
            bitmap11.Save(ms, ImageFormat.Png);
            string firstbitmp = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;
            bitmap21.Save(ms, ImageFormat.Png);
            string scndbitmap = Convert.ToBase64String(ms.ToArray());
            
            if (firstbitmp.Equals(scndbitmap))
            {
               return true;
            }
            else
            {
               return false;

            }


 
        }

      }
}

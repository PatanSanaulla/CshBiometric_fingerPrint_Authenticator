using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CshBiometric_Metro
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {  // Format(GETDATE(), 'hh:mm')
           this.Hide();
           login ss = new login();
            ss.Show();

        }

        private void Startup_Load(object sender, EventArgs e)
        {

        }

        
    }
}

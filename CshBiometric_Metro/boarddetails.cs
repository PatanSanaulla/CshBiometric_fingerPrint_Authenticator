using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CshBiometric_Metro
{
    public partial class boarddetails : Form
    {
        public boarddetails()
        {
            InitializeComponent();
        }

        private void entryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.metroDetailsDataSet1);

        }

        private void boarddetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'metroDetailsDataSet1.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.metroDetailsDataSet1.Entry);

        }

        private void entryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

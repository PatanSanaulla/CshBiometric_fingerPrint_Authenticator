namespace CshBiometric_Metro
{
    partial class boarddetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boarddetails));
            this.entryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.entryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.entryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroDetailsDataSet1 = new CshBiometric_Metro.MetroDetailsDataSet1();
            this.entryTableAdapter = new CshBiometric_Metro.MetroDetailsDataSet1TableAdapters.EntryTableAdapter();
            this.tableAdapterManager = new CshBiometric_Metro.MetroDetailsDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingNavigator)).BeginInit();
            this.entryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroDetailsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // entryBindingNavigator
            // 
            this.entryBindingNavigator.AddNewItem = null;
            this.entryBindingNavigator.BindingSource = this.entryBindingSource;
            this.entryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.entryBindingNavigator.DeleteItem = null;
            this.entryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.entryBindingNavigatorSaveItem});
            this.entryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.entryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.entryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.entryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.entryBindingNavigator.Name = "entryBindingNavigator";
            this.entryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.entryBindingNavigator.Size = new System.Drawing.Size(595, 25);
            this.entryBindingNavigator.TabIndex = 0;
            this.entryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // entryBindingNavigatorSaveItem
            // 
            this.entryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entryBindingNavigatorSaveItem.Image")));
            this.entryBindingNavigatorSaveItem.Name = "entryBindingNavigatorSaveItem";
            this.entryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.entryBindingNavigatorSaveItem.Text = "Save Data";
            this.entryBindingNavigatorSaveItem.Click += new System.EventHandler(this.entryBindingNavigatorSaveItem_Click);
            // 
            // entryDataGridView
            // 
            this.entryDataGridView.AutoGenerateColumns = false;
            this.entryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.entryDataGridView.DataSource = this.entryBindingSource;
            this.entryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.entryDataGridView.Location = new System.Drawing.Point(12, 37);
            this.entryDataGridView.Name = "entryDataGridView";
            this.entryDataGridView.Size = new System.Drawing.Size(542, 317);
            this.entryDataGridView.TabIndex = 1;
            this.entryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entryDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Aadharno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Aadharno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PassengerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PassengerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BoardingPoint";
            this.dataGridViewTextBoxColumn3.HeaderText = "BoardingPoint";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Time_of_entry";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time_of_entry";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.metroDetailsDataSet1;
            // 
            // metroDetailsDataSet1
            // 
            this.metroDetailsDataSet1.DataSetName = "MetroDetailsDataSet1";
            this.metroDetailsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryTableAdapter
            // 
            this.entryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EntryTableAdapter = this.entryTableAdapter;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.passengersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CshBiometric_Metro.MetroDetailsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // boarddetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(595, 373);
            this.Controls.Add(this.entryDataGridView);
            this.Controls.Add(this.entryBindingNavigator);
            this.Name = "boarddetails";
            this.Text = "boarddetails";
            this.Load += new System.EventHandler(this.boarddetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingNavigator)).EndInit();
            this.entryBindingNavigator.ResumeLayout(false);
            this.entryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroDetailsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroDetailsDataSet1 metroDetailsDataSet1;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private MetroDetailsDataSet1TableAdapters.EntryTableAdapter entryTableAdapter;
        private MetroDetailsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator entryBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton entryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView entryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
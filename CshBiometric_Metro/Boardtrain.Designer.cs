namespace CshBiometric_Metro
{
    partial class Boardtrain
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Button1.Location = new System.Drawing.Point(104, 272);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(249, 40);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "AUTHENTICATE";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(305, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Please Use Your Finger Print to be authenticated into the Metro";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.Location = new System.Drawing.Point(151, 61);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(137, 177);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(304, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "SCAN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Boardtrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(474, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Boardtrain";
            this.Text = "Boardtrain";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button button2;
    }
}
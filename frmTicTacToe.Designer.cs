namespace XnO
{
    partial class FrmTicTacToe
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flwLayoutGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flwLayoutGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flwLayoutGrid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 381);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flwLayoutGrid
            // 
            this.flwLayoutGrid.BackColor = System.Drawing.Color.Black;
            this.flwLayoutGrid.Controls.Add(this.pnl1);
            this.flwLayoutGrid.Controls.Add(this.pnl2);
            this.flwLayoutGrid.Controls.Add(this.pnl3);
            this.flwLayoutGrid.Controls.Add(this.pnl4);
            this.flwLayoutGrid.Controls.Add(this.pnl5);
            this.flwLayoutGrid.Controls.Add(this.pnl6);
            this.flwLayoutGrid.Controls.Add(this.pnl7);
            this.flwLayoutGrid.Controls.Add(this.pnl8);
            this.flwLayoutGrid.Controls.Add(this.pnl9);
            this.flwLayoutGrid.ForeColor = System.Drawing.Color.Black;
            this.flwLayoutGrid.Location = new System.Drawing.Point(3, 3);
            this.flwLayoutGrid.Name = "flwLayoutGrid";
            this.flwLayoutGrid.Size = new System.Drawing.Size(321, 321);
            this.flwLayoutGrid.TabIndex = 0;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Location = new System.Drawing.Point(3, 3);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(100, 100);
            this.pnl1.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(109, 3);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(100, 100);
            this.pnl2.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.Location = new System.Drawing.Point(215, 3);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(100, 100);
            this.pnl3.TabIndex = 1;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.White;
            this.pnl4.Location = new System.Drawing.Point(3, 109);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(100, 100);
            this.pnl4.TabIndex = 2;
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(109, 109);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(100, 100);
            this.pnl5.TabIndex = 1;
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.Location = new System.Drawing.Point(215, 109);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(100, 100);
            this.pnl6.TabIndex = 1;
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.White;
            this.pnl7.Location = new System.Drawing.Point(3, 215);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(100, 100);
            this.pnl7.TabIndex = 3;
            // 
            // pnl8
            // 
            this.pnl8.BackColor = System.Drawing.Color.White;
            this.pnl8.Location = new System.Drawing.Point(109, 215);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(100, 100);
            this.pnl8.TabIndex = 3;
            // 
            // pnl9
            // 
            this.pnl9.BackColor = System.Drawing.Color.White;
            this.pnl9.Location = new System.Drawing.Point(215, 215);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(100, 100);
            this.pnl9.TabIndex = 3;
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmTicTacToe";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flwLayoutGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flwLayoutGrid;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl9;
    }
}


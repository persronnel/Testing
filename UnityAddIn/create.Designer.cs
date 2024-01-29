namespace UnityAddIn
{
    partial class CreateForm
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
            this.ATTB = new System.Windows.Forms.TextBox();
            this.RFTB = new System.Windows.Forms.TextBox();
            this.PrTB = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.LocTB = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.DescTB = new System.Windows.Forms.TextBox();
            this.LDTB = new System.Windows.Forms.TextBox();
            this.ATTB2 = new System.Windows.Forms.TextBox();
            this.RFTB2 = new System.Windows.Forms.TextBox();
            this.Subm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CTTB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ATTB
            // 
            this.ATTB.Location = new System.Drawing.Point(272, 203);
            this.ATTB.Name = "ATTB";
            this.ATTB.ReadOnly = true;
            this.ATTB.Size = new System.Drawing.Size(100, 20);
            this.ATTB.TabIndex = 1;
            this.ATTB.Text = "Assigned To:";
            // 
            // RFTB
            // 
            this.RFTB.Location = new System.Drawing.Point(272, 230);
            this.RFTB.Name = "RFTB";
            this.RFTB.ReadOnly = true;
            this.RFTB.Size = new System.Drawing.Size(100, 20);
            this.RFTB.TabIndex = 3;
            this.RFTB.Text = "Requested For:";
            // 
            // PrTB
            // 
            this.PrTB.Location = new System.Drawing.Point(272, 257);
            this.PrTB.Name = "PrTB";
            this.PrTB.ReadOnly = true;
            this.PrTB.Size = new System.Drawing.Size(100, 20);
            this.PrTB.TabIndex = 5;
            this.PrTB.Text = "Priority:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(383, 257);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // LocTB
            // 
            this.LocTB.Location = new System.Drawing.Point(272, 314);
            this.LocTB.Name = "LocTB";
            this.LocTB.ReadOnly = true;
            this.LocTB.Size = new System.Drawing.Size(100, 20);
            this.LocTB.TabIndex = 7;
            this.LocTB.Text = "Location:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(383, 314);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(172, 21);
            this.comboBox4.TabIndex = 6;
            // 
            // DescTB
            // 
            this.DescTB.Location = new System.Drawing.Point(159, 34);
            this.DescTB.Multiline = true;
            this.DescTB.Name = "DescTB";
            this.DescTB.ReadOnly = true;
            this.DescTB.Size = new System.Drawing.Size(491, 48);
            this.DescTB.TabIndex = 8;
            this.DescTB.TextChanged += new System.EventHandler(this.DescTB_TextChanged);
            // 
            // LDTB
            // 
            this.LDTB.Location = new System.Drawing.Point(159, 98);
            this.LDTB.Multiline = true;
            this.LDTB.Name = "LDTB";
            this.LDTB.Size = new System.Drawing.Size(491, 76);
            this.LDTB.TabIndex = 9;
            // 
            // ATTB2
            // 
            this.ATTB2.Location = new System.Drawing.Point(383, 202);
            this.ATTB2.Name = "ATTB2";
            this.ATTB2.Size = new System.Drawing.Size(172, 20);
            this.ATTB2.TabIndex = 10;
            // 
            // RFTB2
            // 
            this.RFTB2.Location = new System.Drawing.Point(383, 228);
            this.RFTB2.Name = "RFTB2";
            this.RFTB2.Size = new System.Drawing.Size(172, 20);
            this.RFTB2.TabIndex = 11;
            // 
            // Subm
            // 
            this.Subm.Location = new System.Drawing.Point(358, 355);
            this.Subm.Name = "Subm";
            this.Subm.Size = new System.Drawing.Size(75, 23);
            this.Subm.TabIndex = 12;
            this.Subm.Text = "Submit";
            this.Subm.UseVisualStyleBackColor = true;
            this.Subm.Click += new System.EventHandler(this.Subm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Case Type:";
            // 
            // CTTB
            // 
            this.CTTB.FormattingEnabled = true;
            this.CTTB.Location = new System.Drawing.Point(383, 287);
            this.CTTB.Name = "CTTB";
            this.CTTB.Size = new System.Drawing.Size(172, 21);
            this.CTTB.TabIndex = 14;
            this.CTTB.SelectedIndexChanged += new System.EventHandler(this.CTTB_SelectedIndexChanged);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CTTB);
            this.Controls.Add(this.Subm);
            this.Controls.Add(this.RFTB2);
            this.Controls.Add(this.ATTB2);
            this.Controls.Add(this.LDTB);
            this.Controls.Add(this.DescTB);
            this.Controls.Add(this.LocTB);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.PrTB);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.RFTB);
            this.Controls.Add(this.ATTB);
            this.Name = "CreateForm";
            this.Text = "create";
            this.Load += new System.EventHandler(this.create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ATTB;
        private System.Windows.Forms.TextBox RFTB;
        private System.Windows.Forms.TextBox PrTB;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox LocTB;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox DescTB;
        private System.Windows.Forms.TextBox LDTB;
        private System.Windows.Forms.TextBox ATTB2;
        private System.Windows.Forms.TextBox RFTB2;
        private System.Windows.Forms.Button Subm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CTTB;
    }
}
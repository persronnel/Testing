namespace UnityAddIn
{
    partial class Resolve
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
            this.DescTB = new System.Windows.Forms.TextBox();
            this.RCTB2 = new System.Windows.Forms.TextBox();
            this.RCTB = new System.Windows.Forms.TextBox();
            this.SDTB2 = new System.Windows.Forms.TextBox();
            this.SDTB = new System.Windows.Forms.TextBox();
            this.Subm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescTB
            // 
            this.DescTB.Location = new System.Drawing.Point(170, 104);
            this.DescTB.Multiline = true;
            this.DescTB.Name = "DescTB";
            this.DescTB.ReadOnly = true;
            this.DescTB.Size = new System.Drawing.Size(491, 48);
            this.DescTB.TabIndex = 9;
            // 
            // RCTB2
            // 
            this.RCTB2.Location = new System.Drawing.Point(170, 195);
            this.RCTB2.Multiline = true;
            this.RCTB2.Name = "RCTB2";
            this.RCTB2.Size = new System.Drawing.Size(491, 53);
            this.RCTB2.TabIndex = 14;
            // 
            // RCTB
            // 
            this.RCTB.Location = new System.Drawing.Point(170, 169);
            this.RCTB.Name = "RCTB";
            this.RCTB.ReadOnly = true;
            this.RCTB.Size = new System.Drawing.Size(171, 20);
            this.RCTB.TabIndex = 12;
            this.RCTB.Text = "Root Cause/Summary of the Case:";
            // 
            // SDTB2
            // 
            this.SDTB2.Location = new System.Drawing.Point(170, 294);
            this.SDTB2.Multiline = true;
            this.SDTB2.Name = "SDTB2";
            this.SDTB2.Size = new System.Drawing.Size(491, 53);
            this.SDTB2.TabIndex = 16;
            // 
            // SDTB
            // 
            this.SDTB.Location = new System.Drawing.Point(170, 268);
            this.SDTB.Name = "SDTB";
            this.SDTB.ReadOnly = true;
            this.SDTB.Size = new System.Drawing.Size(105, 20);
            this.SDTB.TabIndex = 15;
            this.SDTB.Text = "Solution Description:";
            this.SDTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Subm
            // 
            this.Subm.Location = new System.Drawing.Point(361, 373);
            this.Subm.Name = "Subm";
            this.Subm.Size = new System.Drawing.Size(75, 23);
            this.Subm.TabIndex = 17;
            this.Subm.Text = "Submit";
            this.Subm.UseVisualStyleBackColor = true;
            this.Subm.Click += new System.EventHandler(this.Subm_Click);
            // 
            // Resolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Subm);
            this.Controls.Add(this.SDTB2);
            this.Controls.Add(this.SDTB);
            this.Controls.Add(this.RCTB2);
            this.Controls.Add(this.RCTB);
            this.Controls.Add(this.DescTB);
            this.Name = "Resolve";
            this.Text = "Resolve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescTB;
        private System.Windows.Forms.TextBox RCTB2;
        private System.Windows.Forms.TextBox RCTB;
        private System.Windows.Forms.TextBox SDTB2;
        private System.Windows.Forms.TextBox SDTB;
        private System.Windows.Forms.Button Subm;
    }
}
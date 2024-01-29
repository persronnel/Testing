namespace UnityAddIn
{
    partial class EdtForm
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
            this.Subm = new System.Windows.Forms.Button();
            this.LocTB = new System.Windows.Forms.TextBox();
            this.LocCB2 = new System.Windows.Forms.ComboBox();
            this.PrTB = new System.Windows.Forms.TextBox();
            this.ImpCB2 = new System.Windows.Forms.ComboBox();
            this.RFTB = new System.Windows.Forms.TextBox();
            this.ATTB = new System.Windows.Forms.TextBox();
            this.PrioCB2 = new System.Windows.Forms.ComboBox();
            this.UrgCB2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DescTB
            // 
            this.DescTB.Location = new System.Drawing.Point(148, 68);
            this.DescTB.Multiline = true;
            this.DescTB.Name = "DescTB";
            this.DescTB.ReadOnly = true;
            this.DescTB.Size = new System.Drawing.Size(491, 48);
            this.DescTB.TabIndex = 9;
            // 
            // Subm
            // 
            this.Subm.Location = new System.Drawing.Point(348, 321);
            this.Subm.Name = "Subm";
            this.Subm.Size = new System.Drawing.Size(75, 23);
            this.Subm.TabIndex = 24;
            this.Subm.Text = "Submit";
            this.Subm.UseVisualStyleBackColor = true;
            // 
            // LocTB
            // 
            this.LocTB.Location = new System.Drawing.Point(262, 250);
            this.LocTB.Name = "LocTB";
            this.LocTB.ReadOnly = true;
            this.LocTB.Size = new System.Drawing.Size(100, 20);
            this.LocTB.TabIndex = 21;
            this.LocTB.Text = "Location:";
            // 
            // LocCB2
            // 
            this.LocCB2.FormattingEnabled = true;
            this.LocCB2.Location = new System.Drawing.Point(373, 250);
            this.LocCB2.Name = "LocCB2";
            this.LocCB2.Size = new System.Drawing.Size(172, 21);
            this.LocCB2.TabIndex = 20;
            // 
            // PrTB
            // 
            this.PrTB.Location = new System.Drawing.Point(262, 223);
            this.PrTB.Name = "PrTB";
            this.PrTB.ReadOnly = true;
            this.PrTB.Size = new System.Drawing.Size(100, 20);
            this.PrTB.TabIndex = 19;
            this.PrTB.Text = "Impact:";
            // 
            // ImpCB2
            // 
            this.ImpCB2.FormattingEnabled = true;
            this.ImpCB2.Location = new System.Drawing.Point(373, 223);
            this.ImpCB2.Name = "ImpCB2";
            this.ImpCB2.Size = new System.Drawing.Size(172, 21);
            this.ImpCB2.TabIndex = 18;
            // 
            // RFTB
            // 
            this.RFTB.Location = new System.Drawing.Point(262, 196);
            this.RFTB.Name = "RFTB";
            this.RFTB.ReadOnly = true;
            this.RFTB.Size = new System.Drawing.Size(100, 20);
            this.RFTB.TabIndex = 17;
            this.RFTB.Text = "Urgency:";
            // 
            // ATTB
            // 
            this.ATTB.Location = new System.Drawing.Point(262, 169);
            this.ATTB.Name = "ATTB";
            this.ATTB.ReadOnly = true;
            this.ATTB.Size = new System.Drawing.Size(100, 20);
            this.ATTB.TabIndex = 16;
            this.ATTB.Text = "Priority:";
            // 
            // PrioCB2
            // 
            this.PrioCB2.FormattingEnabled = true;
            this.PrioCB2.Location = new System.Drawing.Point(373, 169);
            this.PrioCB2.Name = "PrioCB2";
            this.PrioCB2.Size = new System.Drawing.Size(172, 21);
            this.PrioCB2.TabIndex = 25;
            // 
            // UrgCB2
            // 
            this.UrgCB2.FormattingEnabled = true;
            this.UrgCB2.Location = new System.Drawing.Point(373, 196);
            this.UrgCB2.Name = "UrgCB2";
            this.UrgCB2.Size = new System.Drawing.Size(172, 21);
            this.UrgCB2.TabIndex = 26;
            // 
            // EdtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UrgCB2);
            this.Controls.Add(this.PrioCB2);
            this.Controls.Add(this.Subm);
            this.Controls.Add(this.LocTB);
            this.Controls.Add(this.LocCB2);
            this.Controls.Add(this.PrTB);
            this.Controls.Add(this.ImpCB2);
            this.Controls.Add(this.RFTB);
            this.Controls.Add(this.ATTB);
            this.Controls.Add(this.DescTB);
            this.Name = "EdtForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescTB;
        private System.Windows.Forms.Button Subm;
        private System.Windows.Forms.TextBox LocTB;
        private System.Windows.Forms.ComboBox LocCB2;
        private System.Windows.Forms.TextBox PrTB;
        private System.Windows.Forms.ComboBox ImpCB2;
        private System.Windows.Forms.TextBox RFTB;
        private System.Windows.Forms.TextBox ATTB;
        private System.Windows.Forms.ComboBox PrioCB2;
        private System.Windows.Forms.ComboBox UrgCB2;
    }
}
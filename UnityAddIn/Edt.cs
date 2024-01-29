using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnityAddIn
{
    public partial class EdtForm : Form
    {
        public EdtForm(string description, string body)
        {
            InitializeComponent();
            DescTB.Text = "Resolve case " + description;

            PrioCB2.Items.AddRange(new object[] { "P4", "P3", "P2", "P1" });
            PrioCB2.SelectedIndex = PrioCB2.Items.IndexOf("P4");
            ImpCB2.Items.AddRange(new object[] { "P4", "P3", "P2", "P1" });
            ImpCB2.SelectedIndex = ImpCB2.Items.IndexOf("P4");
            UrgCB2.Items.AddRange(new object[] { "P4", "P3", "P2", "P1" });
            UrgCB2.SelectedIndex = UrgCB2.Items.IndexOf("P4");
            LocCB2.Items.AddRange(new object[] { "France", "Czeh Republic", "Italy", "South Africa" });
            LocCB2.SelectedIndex = LocCB2.Items.IndexOf("France");
        }
    }
}

using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnityAddIn
{
    public partial class CreateForm : Form
    {
        private Microsoft.Office.Interop.Outlook.MailItem lastInspectedMailItem;
        private MailItem mailItem;

        public CreateForm(string from, string to, string description, string longDescription)
        {
            InitializeComponent();
            this.lastInspectedMailItem = mailItem;

            RFTB2.Text = from;
            ATTB2.Text = to;
            DescTB.Text = "Create case for " + description;
            LDTB.Text = longDescription;

            comboBox3.Items.AddRange(new object[] { "P4", "P3", "P2", "P1" });
            comboBox3.SelectedIndex = comboBox3.Items.IndexOf("P4");

            comboBox4.Items.AddRange(new object[] { "France", "Czech Republic", "Italy"});
            comboBox4.SelectedIndex = comboBox4.Items.IndexOf("France");

            CTTB.Items.AddRange(new object[] { "Incident", "Request" });
            CTTB.SelectedIndex = CTTB.Items.IndexOf("Request");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void create_Load(object sender, EventArgs e)
        {
            ATTB2.Focus();
        }

        private void DescTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Subm_Click(object sender, EventArgs e)
        {
            string location = comboBox4.SelectedItem.ToString();
            string priority = comboBox3.SelectedItem.ToString();
            string assignedTo = ATTB2.Text;
            string body = LDTB.Text;
            string sdesc = DescTB.Text;
            string reqFor = RFTB2.Text;

            var requestData = new
            {
                Location = location,
                Priority = priority,
                AssignedToEmailID = assignedTo,
                Description = sdesc,
                EndUserEmailID = reqFor
            };

            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

            string postApiUrl = "";  
            string bearerToken = ""; 

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", bearerToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(postApiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic responseData = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);
                    string caseNumber = responseData?.CaseNumber;
                    if (!string.IsNullOrEmpty(caseNumber))
                    {
                        string newSubject = $"Case - {caseNumber}";
                        UpdateSubject(newSubject);
                        MessageBox.Show($"POST request sent successfully. Subject updated to: {newSubject}");
                    }
                    else
                    {
                        MessageBox.Show("Error: Case number not found in the JSON response.");
                    }
                }
                else
                {
                    MessageBox.Show($"Error sending POST request: {response.StatusCode}");
                }
            }
        }

        private void UpdateSubject(string newSubject)
        {
            if (lastInspectedMailItem != null)
            {
                lastInspectedMailItem.Subject = newSubject;
                lastInspectedMailItem.Save();
            }
        }

        private void CTTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
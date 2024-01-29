using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnityAddIn
{
    public partial class Resolve : Form
    {
        public Resolve(string description, string body)
        {
            InitializeComponent();
            DescTB.Text = "Resolve case " + description;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Subm_Click(object sender, EventArgs e)
        {
            string solution = SDTB2.Text;
            string rootcause = RCTB2.Text;

            var requestData = new
            {
                Rootcause = rootcause,
                SolutionDescription = solution,
                TicketStatus = "Pending User"
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
                    MessageBox.Show("POST request sent successfully.");
                }
                else
                {
                    MessageBox.Show($"Error sending POST request: {response.StatusCode}");
                }
            }
        }
    }

}

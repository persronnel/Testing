using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace UnityAddIn
{
    public partial class Ribbon1
    {
        private const string ApiBaseUrl = "https://your-api-endpoint.com/api";
        private Outlook.MailItem lastInspectedMailItem;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void create_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();
            Outlook.Explorer activeExplorer = Globals.ThisAddIn.Application.ActiveExplorer();

            if (inspector != null && inspector.CurrentItem is Outlook.MailItem)
            {
                lastInspectedMailItem = inspector.CurrentItem as Outlook.MailItem;
            }
            else if (activeExplorer != null && activeExplorer.Selection.Count > 0)
            {
                lastInspectedMailItem = activeExplorer.Selection[1] as Outlook.MailItem;
            }

            if (lastInspectedMailItem != null)
            {
                string senderEmailAddress = GetSenderEmailAddress(lastInspectedMailItem);
                string loggedInUser = GetLoggedInUser();

                using (var createForm = new CreateForm(senderEmailAddress, loggedInUser, lastInspectedMailItem.Subject, lastInspectedMailItem.Body))
                {
                    createForm.ShowDialog();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select an email to create.");
            }
        }

        private string GetSenderEmailAddress(Outlook.MailItem mailItem)
        {
            try
            {
                if (mailItem.SenderEmailType == "EX" || mailItem.SenderEmailType == "SMTP")
                {
                    // For Exchange or SMTP addresses, use the Sender property
                    string senderAddress = mailItem.Sender.Address;

                    // Use PropertyAccessor to get the SMTP address
                    Outlook.PropertyAccessor propertyAccessor = mailItem.Sender.PropertyAccessor;
                    string smtpAddress = propertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x39FE001E");

                    // Return the SMTP address if available, otherwise return the original sender address
                    return !string.IsNullOrEmpty(smtpAddress) ? smtpAddress : senderAddress;
                }
                else
                {
                    // For other address types, try using the SenderEmailAddress property
                    return mailItem.SenderEmailAddress;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while retrieving the sender's email address
                System.Diagnostics.Debug.WriteLine($"Error getting sender's email address: {ex.Message}");
                return null;
            }
        }

        private string GetLoggedInUser()
        {
            Outlook.Application outlookApp = Globals.ThisAddIn.Application;
            Outlook.NameSpace outlookNamespace = outlookApp.GetNamespace("MAPI");
            Outlook.Accounts accounts = outlookNamespace.Accounts;
            string loggedInUser = accounts.Cast<Outlook.Account>().FirstOrDefault(a => a.CurrentUser != null)?.SmtpAddress;
            return loggedInUser;
        }




        private void resolve_Click(object sender, RibbonControlEventArgs e)
        {
            SendJsonRequest("YourResolveEndpoint", new { Key = "value" });
        }

        private void close_Click(object sender, RibbonControlEventArgs e)
        {
            // Call the method to send JSON PUT request
            SendJsonRequest("YourCloseEndpoint", new { Key = "value" });
        }

        private void search_Click(object sender, RibbonControlEventArgs e)
        {
            // Call the method to send JSON PUT request
            SendJsonRequest("YourSearchEndpoint", new { Key = "value" });
        }

        private void edt_Click(object sender, RibbonControlEventArgs e)
        {
            // Call the method to send JSON PUT request
            SendJsonRequest("YourEditEndpoint", new { Key = "value" });
        }

        private void SendJsonRequest(string endpoint, object data)
        {
            try
            {
                Outlook.Application outlookApp = Globals.ThisAddIn.Application;
                Outlook.Explorer activeExplorer = outlookApp.ActiveExplorer();

                // Convert the data object to JSON
                string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                // Send the JSON PUT request to your API
                SendPutRequest(ApiBaseUrl + $"/{endpoint}", jsonPayload).Wait();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error sending JSON PUT request: {ex.Message}");
            }
        }

        private async Task SendPutRequest(string url, string jsonPayload)
        {
            using (HttpClient client = new HttpClient())
            {
                // Set the content type to application/json
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Create a StringContent with the JSON payload
                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // Send the PUT request
                HttpResponseMessage response = await client.PutAsync(url, content);

                // Handle the response if needed
                if (!response.IsSuccessStatusCode)
                {
                    // Handle the error (e.g., show a message box)
                    System.Windows.Forms.MessageBox.Show($"Error: {response.ReasonPhrase}");
                }
            }
        }
    }
}

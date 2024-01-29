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
                    string senderAddress = mailItem.Sender.Address;
                    Outlook.PropertyAccessor propertyAccessor = mailItem.Sender.PropertyAccessor;
                    string smtpAddress = propertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x39FE001E");
                    return !string.IsNullOrEmpty(smtpAddress) ? smtpAddress : senderAddress;
                }
                else
                {
                    return mailItem.SenderEmailAddress;
                }
            }
            catch (Exception ex)
            {
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

                using (var resolveForm = new Resolve(lastInspectedMailItem.Subject, lastInspectedMailItem.Body))
                {
                    resolveForm.ShowDialog();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select an email to resolve.");
            }
        }

        private void closeButton_Click(object sender, RibbonControlEventArgs e)
        {
            SendJsonRequest("YourCloseEndpoint", new { Key = "value" });
        }

        private void searchButton_Click(object sender, RibbonControlEventArgs e)
        {
            SendJsonRequest("YourSearchEndpoint", new { Key = "value" });
        }

        private void edt_Click(object sender, RibbonControlEventArgs e)
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

                using (var EdtForm = new EdtForm(lastInspectedMailItem.Subject, lastInspectedMailItem.Body))
                {
                    EdtForm.ShowDialog();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select an email to resolve.");
            }
        }

        private void SendJsonRequest(string endpoint, object data)
        {
            try
            {
                Outlook.Application outlookApp = Globals.ThisAddIn.Application;
                Outlook.Explorer activeExplorer = outlookApp.ActiveExplorer();
                string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(data);
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
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    System.Windows.Forms.MessageBox.Show($"Error: {response.ReasonPhrase}");
                }
            }
        }
    }
}

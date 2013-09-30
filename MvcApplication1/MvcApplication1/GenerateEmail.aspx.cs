using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MvcApplication1
{
    
    public partial class GenerateEmail : System.Web.UI.Page
    {
        string sBody = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sBody = "Dear "+txtRecipientName.ToString();
           

            sBody += System.IO.File.ReadAllText(@"c:\users\student\documents\visual studio 2012\Projects\MvcApplication1\MvcApplication1\Email.txt");

            sBody += "\n\n http://localhost:49394//RefLanding.aspx";
            sBody += "\n\nPasscode : yess";

            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add(txtRecipientEmail.Text.ToString());
            message.Subject = "Confidential Personal Enquiry for "+"Applicant Name";
            message.From = new System.Net.Mail.MailAddress("sweproject9@gmail.com");
            message.Body = sBody;
            System.Net.Mail.SmtpClient mySmtpClient = new System.Net.Mail.SmtpClient();
            System.Net.NetworkCredential myCredential = new System.Net.NetworkCredential("sweproject9@gmail.com", "project9password");
            mySmtpClient.Host = "smtp.gmail.com";  //Have specified the smtp host name
            mySmtpClient.UseDefaultCredentials = false;
            mySmtpClient.Port = 587;
            mySmtpClient.Credentials = myCredential;
            mySmtpClient.EnableSsl = true;
            mySmtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

           // System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("email.usc.edu");
           mySmtpClient.Send(message);
        }
    }
}
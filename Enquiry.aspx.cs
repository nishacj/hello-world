using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
        
        
        }
    }

    protected void Unnamed_Click(object sender, EventArgs e)
    {
        if (txtemail.Text != "" && txtMessage.Text != "" && txtname.Text != "" && txtPhone.Text != "")
        {
            try
            {
                //Create the msg object to be sent
                MailMessage msg = new MailMessage();
                //Add your email address to the recipients
                msg.To.Add("jjrampur@gmail.com");
                //Configure the address we are sending the mail from
                MailAddress address = new MailAddress("jjrampur@gmail.com");
                msg.From = address;
                msg.Subject = txtemail.Text;
                msg.Body = "<font style='font-weight:bold;'>Your Name: </font>" + txtname.Text + "<br> <font style='font-weight:bold;'>Email: </font>" + txtemail.Text + "<br> <font style='font-weight:bold;'>Phone: </font>" + txtPhone.Text+ " <br> <font style='font-weight:bold;'>Message: </font>" + txtMessage.Text;
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client.Host = "relay-hosting.secureserver.net";
                client.Port = 25;
                client.EnableSsl = false;

                //Send the msg
                client.Send(msg);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Thank You. We will contact you Shortly.'); window.location.href='Enquiry.aspx';", true);
            }
            catch (Exception)
            {

            }
        }
        else
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "script", "alert('Fill all required fields.'); window.location.href='Enquiry.aspx';", true);
        }
    }
}

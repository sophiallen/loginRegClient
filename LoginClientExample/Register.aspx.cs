using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        RegisterReviewer();
    }

    protected void RegisterReviewer()
    {
        LoginRegServiceRef.LoginServiceClient lsc = new LoginRegServiceRef.LoginServiceClient();
        LoginRegServiceRef.Reviewer r = new LoginRegServiceRef.Reviewer();
        //get data from textfields goes here
        r.ReviewerFirstName = FirstNameTextBox.Text;
        r.ReviewerLastName = LastNameTextBox.Text;
        r.ReviewerUserName = EmailTextBox.Text;
        r.ReviewerEmail = EmailTextBox.Text;
        r.ReviewPlainPassword = PasswordTextBox.Text;

        //check result, then redirect on success, else show error. 
        bool result = lsc.RegisterReviewer(r);
        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Registration Error";
        }
    }
}
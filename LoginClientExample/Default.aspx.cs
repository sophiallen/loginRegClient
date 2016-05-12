using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        Login();
    }

    protected void Login()
    {
        LoginRegServiceRef.LoginServiceClient rs = new LoginRegServiceRef.LoginServiceClient();
        int key = rs.ReviewerLogin(UsernameTextBox.Text, PasswordTextBox.Text); //technically, we should validate instead of using data directly from the input field. 
        if(key != 0) //zero represents login failure. 
        {
            ErrorLabel.Text = "Welcome"; //later this will redirect to new page. 
            Session["UserKey"] = key; //session data is stored in the server as long as the client is connected to the website. 
        } else
        {
            ErrorLabel.Text = "Invalid Login";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VenueLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        ReveiwerLogin();
    }

    protected void ReveiwerLogin()
    {
        ServiceReferenceShowTracker.LoginServiceClient lsc =
            new ServiceReferenceShowTracker.LoginServiceClient();
        int key = lsc.VenueLogin(PasswordTextBox.Text, UserNameTextBox.Text);
        if(key != -1)
        {
            ErrorLabel.Text = "Welcome!";
            Session ["userkey"] = key;
        }
        else
        {
            ErrorLabel.Text = "Login Failed";
        }
    }
}
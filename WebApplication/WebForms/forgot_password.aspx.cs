using BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.WebForms
{
    public partial class forgot_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            UserDetails user = new UserDetails();
            user.UserName = username_textbox.Text;
            user.Password = password_textbox.Text;

            string confirmPassword = submit_button.Text;

            Authentications authObj = new Authentications();
            authObj.ForgotPassword(user);

            isvalid_textbox.Text = Literals.Password_Update_Successful;
        }
    }
}
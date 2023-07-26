using BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.WebForms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            UserDetails user = new UserDetails();
            user.UserName = username_textbox.Text;
            user.Email = email_textbox.Text;
            user.Password = password_textbox.Text;
            string confirmPassword = confirmPassword_textbox.Text;

            if(user.Password != confirmPassword)
            {
                isvalidRegistration_textbox.Text = Literals.Invalid_ConfirmPassword;

            }
            else
            {
                Authentications authObj = new Authentications();
                string isValidUser = authObj.Signup(user);
                isvalidRegistration_textbox.Text = isValidUser;
            }
            
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}
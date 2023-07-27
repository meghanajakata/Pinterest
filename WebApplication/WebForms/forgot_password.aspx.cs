using BusinessModels;
using System;


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

            string confirmPassword = confirmPassword_textbox.Text;

            if(confirmPassword == user.Password)
            {
                Authentications authObj = new Authentications();

                isvalid_textbox.Text = authObj.ForgotPassword(user);

            }

            else
            {
                isvalid_textbox.ForeColor = System.Drawing.Color.Red; ;
                isvalid_textbox.Text = Literals.Invalid_ConfirmPassword;
            }
            

        }
    }
}
using System;
using BusinessModels;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.WebForms
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            UserDetails user = new UserDetails();
            user.UserName = username_textbox.Text;
            user.Password = password_textbox.Text;

            Authentications authObj = new Authentications();
            string isValidLogin = authObj.Login(user);

            if (isValidLogin == Literals.Login_Success)
            {
                Response.Redirect("Success.aspx");
            }

            else
            {
                isValidLogin_textbox.Text = isValidLogin;
            }
        }


    }
}
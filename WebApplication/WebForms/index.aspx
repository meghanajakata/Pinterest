<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication.WebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        body 
        {
              justify-content: center;
              display: flex;
        }

        .container
        {
            margin-top: 20px;
            display: flex;
        }

        .innerContainer1
        {
            padding:20px;
            background-color: beige;
            width:50%;
            text-align:center;
            border-radius:5px;
        }
        
        .innerContainer2
        {
            padding:20px;
        }

        .textbox_display
        {
            display:block;
            width: 70%;
            height: 30px;
            border:thin 3px black;
            margin-top:3px;
        }

        #signin_button
        {
            color: ghostwhite;
            padding-left:10px;
            padding-right:10px;
            padding-top: 8px;
            padding-bottom:8px;
            background-color:darkslategrey;
            border-radius:5px;
        }

        #signup_button
        {
            color: ghostwhite;
            padding-left:10px;
            padding-right:10px;
            padding-top: 8px;
            padding-bottom:8px;
            background-color:darkslategrey;
            border-radius:5px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="innerContainer1">
                <h1>Welcome Back!!!</h1>          
                To keep Connected with us please login with your personal Info
                <br /><br />
                <asp:Button ID="signin_button" runat="server" Text="Sign In" OnClick="SignIn_Click" ></asp:Button>
            </div>
            <div class="innerContainer2">
                <h1>Create Account</h1>
                <asp:TextBox class="textbox_display" ID="username_textbox" runat="server" placeholder="Username" ></asp:TextBox>
                <asp:TextBox class="textbox_display" ID="email_textbox" runat="server" placeholder="Emailid"></asp:TextBox>
                <asp:TextBox class="textbox_display" ID="password_textbox" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                <asp:TextBox class="textbox_display" ID="confirmPassword_textbox" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                <br />

                <asp:Label ID="isvalidRegistration_textbox" ForeColor="Red" runat="server" ></asp:Label>

                <br />
                <asp:Button ID="signup_button" runat="server" Text="Sign Up" OnClick="SignUp_Click"></asp:Button>
            </div>
        </div>
    </form>
</body>
</html>

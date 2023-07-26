<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication.WebForms.login" %>

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
            margin: 20px;
            padding: 0 50px 50px 50px;
            background-color: beige;
            text-align:center;
            width:250px;
        }
        
        .textbox_display
        {
            display:block;
            width: 70%;
            height: 30px;
            border:thin 3px black;
            margin-top:3px;
            margin-left:10px;
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
    </style>

</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
            <h1>SignIn</h1>
            <asp:TextBox class="textbox_display" ID="username_textbox" runat="server" placeholder="Username" ></asp:TextBox>
            <asp:TextBox class="textbox_display" ID="password_textbox" runat="server" placeholder="Password"></asp:TextBox>
            <br />
            <asp:Label ID="isValidLogin_textbox" ForeColor="Red" runat="server" ></asp:Label>
            <br />
            <a href="forgot_password.aspx">Forgot Password</a>
            <br />
            <asp:Button ID="signin_button" runat="server" Text="SignIn" OnClick="SignIn_Click"></asp:Button>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot_password.aspx.cs" Inherits="WebApplication.WebForms.forgot_password" %>

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
        }

        #submit_button
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
             <h1>Forgot Password</h1>
            <asp:TextBox class="textbox_display" ID="username_textbox" runat="server" placeholder="Username" ></asp:TextBox>
            <asp:TextBox class="textbox_display" ID="password_textbox" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
            <asp:TextBox class="textbox_display" ID="confirmPassword_textbox" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>

            <br />
            <asp:Label ID="isvalid_textbox" ForeColor="Green" runat="server" ></asp:Label>
            <br />
            
             <asp:Button ID="submit_button" runat="server" Text="Submit" OnClick="Submit_Click"></asp:Button>
        </div>
    </form>
</body>
</html>

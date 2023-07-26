using System;
using BusinessModels;
using BusinessLayer;

namespace WebApplication
{
    /// <summary>
    /// Represents the Authentications of user for Signup and Login
    /// </summary>
    public class Authentications
    {
        /// <summary>
        /// Registers the user and returns the string
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Signup(UserDetails user)
        {
            BALAuthentications balObj = new BALAuthentications();

            if(!isValidUsername(user.UserName))
            {
                return Literals.Invalid_Username;
            }

            if(!isValidEmail(user.Email))
            {
                return Literals.Invalid_EmailId;
            }

            if(!isValidPassword(user.Password))
            {
                return Literals.Invalid_Password;
            }

            if (balObj.SignUp(user))
            {
                return Literals.SignUp_Success;
            }
            return Literals.User_Exists;
        }

        /// <summary>
        /// Logins the user and returns the string
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Login(UserDetails user)
        {
            BALAuthentications balObj = new BALAuthentications();
            if (user.UserName == "")
            {
                return Literals.Invalid_Username;
            }

            if(user.Password == "")
            {
                return Literals.Invalid_Password;
            }
            if(balObj.Login(user))
            {
                return Literals.Login_Success;
            }
            return Literals.Invalid_Login;
        }

        /// <summary>
        /// Represents the forgot Password for the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string ForgotPassword(UserDetails user)
        {
            return Literals.Password_Update_Successful;
        }

        /// <summary>
        /// Checks whether the username is valid
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool isValidUsername(string username)
        {
            if (username == "") return false;
            return true;    
        }

        /// <summary>
        /// Checks whether the EmailId is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool isValidEmail(string email)
        {
            if(email == "")return false;
            return true;
        }

        /// <summary>
        /// Checks whether the password is valid
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool isValidPassword(string password)
        {
            if (password == "") return false;
            return true;
        }
    }
}
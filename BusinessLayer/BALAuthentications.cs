using BusinessModels;
using DataAccessLayer;
using System.Text;
using System;

namespace BusinessLayer
{
    /// <summary>
    /// Represents the Authentications for Business Layer
    /// </summary>
    public class BALAuthentications
    {
        /// <summary>
        /// Checks the SignUp Authentication of the user in Business Layer 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string SignUp(UserDetails user)
        {
            DataFactory dataFactoryObj = new DataFactory();
            IData dalObj = dataFactoryObj.GetAuthenticationsObject();
            user.Password = EncryptPassword(user.Password);
            return dalObj.SignUp(user);
        }

        /// <summary>
        /// Checks the Login Authentication of the user in Business Layer
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Login(UserDetails user)
        {
            DataFactory dataFactoryObj = new DataFactory();
            IData dalObj = dataFactoryObj.GetAuthenticationsObject();
            user.Password = EncryptPassword(user.Password);
            return dalObj.Login(user);
        }

        /// <summary>
        /// Checks whether the password update is successful
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string ForgotPassword(UserDetails user)
        {
            DataFactory dataFactoryObj = new DataFactory();
            IData dalObj = dataFactoryObj.GetAuthenticationsObject();
            user.Password = EncryptPassword(user.Password);
            return dalObj.ForgotPassword(user);
        }

        /// <summary>
        /// Method to encrypt the password 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string EncryptPassword(string password)
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }
    }
}

using BusinessModels;
using System;

namespace DataAccessLayer
{
    /// <summary>
    /// Represents the authentication for Data Access Layer
    /// </summary>
    public class DALAuthentications
    {
        /// <summary>
        /// Registers the user to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string SignUp(UserDetails user)
        {
            DataSources dataSourcesObj  = new DataSources();
            return dataSourcesObj.AddUser(user);
        }

        /// <summary>
        /// Logins the user to database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Login(UserDetails user)
        {
            DataSources dataSourcesObj = new DataSources();
            string can_UserLogin = dataSourcesObj.IsUserExists(user);
            if(can_UserLogin == Literals.User_Exists)
            {
                return Literals.Login_Success;
            }
            return Literals.Invalid_Login;

        }

        /// <summary>
        /// Update the user with with new password
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string  ForgotPassword(UserDetails user)
        {
            DataSources dataSourcesObj = new DataSources();

            string updatePassword = dataSourcesObj.IsUserSignedIn(user);

            if ( updatePassword == Literals.User_Exists)
            {   
                return dataSourcesObj.UpdateUser(user);
            }
            return updatePassword;
        }

        
    }
}

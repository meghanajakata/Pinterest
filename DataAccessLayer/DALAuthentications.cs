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
        public bool SignUp(UserDetails user)
        {
            DataSources dataSourcesObj  = new DataSources();
            if(dataSourcesObj.AddUser(user))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Logins the user to database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(UserDetails user)
        {
            DataSources dataSourcesObj = new DataSources();
            return dataSourcesObj.IsUserExists(user);
            
        }

        
    }
}

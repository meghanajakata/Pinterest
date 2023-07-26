using BusinessModels;
using DataAccessLayer;

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
        public bool SignUp(UserDetails user)
        {
            DALAuthentications dalObj = new DALAuthentications();
            return dalObj.SignUp(user);
        }

        /// <summary>
        /// Checks the Login Authentication of the user in Business Layer
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(UserDetails user)
        {
            DALAuthentications dalObj = new DALAuthentications();
            return dalObj.Login(user);
        }
    }
}

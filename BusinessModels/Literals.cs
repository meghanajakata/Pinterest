using System.Configuration;

namespace BusinessModels
{
    /// <summary>
    /// Represents the string Literals 
    /// </summary>
    public class Literals
    {
        public static string AddUser_Exception;
        public static string IsUserExists_Exception;
        public static string IsUserSignedIn_Exception;
        public static string UpdateUser_Exception;
        public static string SignUp_Success = "Registration Successful";
        public static string Invalid_Username = "Please enter the valid username";
        public static string Invalid_EmailId = "Please enter the valid EmailId";
        public static string Invalid_Password = "Please enter the valid Password";
        public static string Invalid_ConfirmPassword = "Please make sure your password and confirm password are same";
        public static string Login_Success = "Login Successful";
        public static string User_Exists = "User already exists";
        public static string User_Doesnt_Exist = " User doesn't exist";
        public static string Invalid_Login = "Invalid Login";
        public static string Password_Update_Successful = "password update is successful";
        public static string Password_Update_Unsuccessful = "password update is unsuccessful <br/> Please verify username and Password";
        public static string DbConnection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        // "Data Source=COGNINE-L14\\SQLEXPRESS01;Initial Catalog=meghana;Integrated Security=True";
    }
}

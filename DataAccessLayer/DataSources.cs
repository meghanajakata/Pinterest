using BusinessModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Represents the Operations on database
    /// </summary>
    public class DataSources
    {
        /// <summary>
        /// Checks whether the user is added to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string AddUser(UserDetails user)
        {
            SqlConnection conn = new SqlConnection(Literals.DbConnection);

            string can_AddUser = IsUserSignedIn(user);
            if (can_AddUser == Literals.User_Doesnt_Exist)
            {
                try
                {
                    string query = "insert into people values( @Username,@EmailId,@Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Username", user.UserName);
                    cmd.Parameters.AddWithValue("@EmailId", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return Literals.SignUp_Success;

                }

                catch (SqlException ex)
                {
                    Literals.AddUser_Exception = ex.Message.ToString();
                }

                finally
                {
                    conn.Close();
                }
                return Literals.AddUser_Exception;
            }
            return can_AddUser;
        }

        /// <summary>
        /// Checks whether the user exists in the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string IsUserExists(UserDetails user)
        {
            SqlConnection conn = new SqlConnection(Literals.DbConnection);

            try
            {
                string query = "select * from people where username = @Username and password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", user.UserName);
                cmd.Parameters.AddWithValue("Password", user.Password);

                conn.Open();

                SqlDataReader dataReaderObj = cmd.ExecuteReader();

                if(dataReaderObj.HasRows)
                {
                    return Literals.User_Exists;
                }

                return Literals.User_Doesnt_Exist;
            }
            catch(SqlException ex)
            {
                Literals.IsUserExists_Exception = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
            }
            return Literals.IsUserExists_Exception;
            
        }

        /// <summary>
        /// Checks whether the user has already registered to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string IsUserSignedIn(UserDetails user)
        {
            SqlConnection conn = new SqlConnection(Literals.DbConnection);
            try
            {
                string query = "select * from people where username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", user.UserName);

                conn.Open();

                SqlDataReader dataReaderObj = cmd.ExecuteReader();

                if (dataReaderObj.HasRows)
                {
                    return Literals.User_Exists;
                }

                return Literals.User_Doesnt_Exist;
            }
            catch (SqlException ex)
            {
                Literals.IsUserSignedIn_Exception = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
            }
            return Literals.IsUserSignedIn_Exception;
        }

        /// <summary>
        /// Updates the user with new password
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string UpdateUser(UserDetails user)
        {
            SqlConnection conn = new SqlConnection(Literals.DbConnection);

            try
            {
                string query = "update people set password = @Password where username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", user.UserName);
                cmd.Parameters.AddWithValue("Password", user.Password);

                conn.Open();

                int rowsUpdated = cmd.ExecuteNonQuery();

                if(rowsUpdated > 0)
                {
                    return Literals.Password_Update_Successful;

                }
                return Literals.Password_Update_Unsuccessful;

            }
            catch (SqlException ex)
            {
                Literals.UpdateUser_Exception = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
            }
            return Literals.UpdateUser_Exception;

        }
    }
}

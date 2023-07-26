using BusinessModels;
using System;
using System.Collections.Generic;
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
        public bool AddUser(UserDetails user)
        {
            SqlConnection conn = new SqlConnection(Literals.DbConnection);

            if(IsUserSignedIn(user))
            {
                return false;
            }

            try
            {
                string query = "insert into people values( @Username,@EmailId,@Password)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", user.UserName);
                cmd.Parameters.AddWithValue("@EmailId", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;

            }

            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                conn.Close();
            }
            return false;
        }

        /// <summary>
        /// Checks whether the user exists in the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsUserExists(UserDetails user)
        {
            SqlConnection conn = new SqlConnection(Literals.DbConnection);
            int count;

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
                    return true;
                }

                return false;
            }
            catch(SqlException ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            
        }

        /// <summary>
        /// Checks whether the user has already registered to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsUserSignedIn(UserDetails user)
        {
            SqlConnection conn = new SqlConnection(Literals.DbConnection);
            int count;

            try
            {
                string query = "select * from people where username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", user.UserName);

                conn.Open();

                SqlDataReader dataReaderObj = cmd.ExecuteReader();

                if (dataReaderObj.HasRows)
                {
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace BT02
{
    static class UserSession
    {
        public static int ID { get; set; }
        public static string Name { get; set; } = string.Empty;
        public static string Email { get; set; } = string.Empty;
    }

    public class UserAction
    {
        static string DB_URL = "LAPTOP-LT";
        static string DB_USER = "";
        static string DB_PASS = "";
        static string DB_NAME = "ltm";

        string connectionString = $"Server={DB_URL};Database={DB_NAME};Integrated Security=true";

        public bool LoginSession(string username, string password)
        {
            string hashed_password = sha256(password);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();
                        command.CommandText = "SELECT UserId, Username, Email FROM Users WHERE Username = @username AND Password = @password";
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashed_password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserSession.ID = reader.GetInt32(0);
                                UserSession.Name = reader.GetString(1);
                                UserSession.Email = reader.GetString(2);
                                connection.Close();
                                return true;
                            }
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi xảy ra:\n" + ex);
            }
            return false;
        }

        public bool RegisterUser(string username, string password, string email) 
        {
            string hashed_password = sha256(password);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();
                        command.CommandText = "INSERT INTO Users(Username, Email, Password) VALUES (@username, @email, @password)";
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", hashed_password);
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi xảy ra:\n" + ex);
            }
            return false;
        }

        static string sha256(string str)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

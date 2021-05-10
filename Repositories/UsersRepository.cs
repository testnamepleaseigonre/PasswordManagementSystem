using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PasswordManagementSystem.Models;
using System.IO;
using System.Windows.Forms;

namespace PasswordManagementSystem.Repositories
{
    class UsersRepository
    {
        private static SqlConnection connection = new SqlConnection(@"Server=.;Database=PassManagement;User Id=sa;Password=Thedizzy069");
        private ScryptHasher hasher = new ScryptHasher();
        private string filePath = "C:/Users/valde/source/repos/PasswordManagementSystem/Files/";

        public void register(NewUser user)
        {
            try
            {
                string sql = "insert into users_table (username, password) values (@username, @password)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", user.getUsername());
                cmd.Parameters.AddWithValue("@password", hasher.encrypt(user.getPassword()));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                //File.Create(filePath + user.getUsername() + ".enc");
                //File.AppendAllText(filePath + user.getUsername() + ".enc", "");
                MessageBox.Show("Registered successfully!");
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public LoggedInUser login(string username, string password)
        {
            try
            {
                string sql = "select id, username, password from users_table where username=@username";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                connection.Open();
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string id = dataReader["id"].ToString();
                        string usern = dataReader["username"].ToString();
                        string pass = dataReader["password"].ToString();
                        if(hasher.encrypt(password,pass) == true)
                            return new LoggedInUser(id, username, password);
                    }
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            throw new Exception("Bad Credentials!");
        }
    }
}

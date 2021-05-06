using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PasswordManagementSystem.Models;

namespace PasswordManagementSystem.Repositories
{
    class UsersRepository
    {
        private static SqlConnection connection = new SqlConnection(@"Server=.;Database=PassManagement;User Id=sa;Password=Thedizzy069");

        public void Register(NewUser user)
        {
            try
            {
                string sql = "insert into users_table (username, password) values (@username, @password)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", user.getUsername());
                cmd.Parameters.AddWithValue("@password", user.getPassword());
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
    }
}

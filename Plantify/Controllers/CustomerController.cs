using System;
using Npgsql;
using plantify.Database;

namespace plantify.Controllers
{
    public class CustomerController
    {
        public bool UsernameExists(string username)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public bool EmailExists(string email)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM users WHERE email = @email";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Register(string nama, string email, string username,
                             string password, string alamat, string noHp)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO users 
                                (nama_user, email, username, passwords, alamat, no_telepon, is_admin) 
                                VALUES (@nama, @email, @username, @password, @alamat, @noHp, false)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@noHp", noHp);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
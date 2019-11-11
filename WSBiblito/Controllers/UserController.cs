using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WSBiblito
{
    public class UserController
    {
        string connectionString = @"Data Source=JARV-TRIDENT\SQLEXPRESS;Initial Catalog=Biblito;Integrated Security=True";

        public User CreateUser(User user) {
            string sql = "INSERT INTO [dbo].[User] (username, password, name, idUserType) values (@username,@password,@name,@idUserType)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sql,conn))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@username", user.username));
                    sqlCommand.Parameters.Add(new SqlParameter("@password", user.password));
                    sqlCommand.Parameters.Add(new SqlParameter("@name", user.name));
                    sqlCommand.Parameters.Add(new SqlParameter("@idUserType", user.idUserType));
                    sqlCommand.ExecuteNonQuery();
                }
                conn.Close();
            }
            return GetUser(user.username);
        }

        public User GetUser(string username)
        {
            User user = null;
            string sql = "SELECT * FROM [dbo].[User] WHERE username ='"+username+"'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sql,conn))
                {
                  //  sqlCommand.Parameters.Add(new SqlParameter("@username", username));
                    using (SqlDataReader res = sqlCommand.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            user = new User()
                            {
                                idUser = (int)res["idUser"],
                                username = (string)res["username"],
                                name = (string)res["name"],
                                idUserType = (int)res["idUserType"],
                            };
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }
    }
}
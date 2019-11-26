using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ServicioUser;

namespace ServicioUser
{
    public class UserDAO
    {
        private string CadenaConexion = @"Data Source=LAPTOP-4QVRIF7D\SQLEXPRESS;Initial Catalog=Biblito;Integrated Security=True;";

        public Usuario CreateUser(Usuario UsertoCreate)
        {
            Usuario CreatedUser = null;
            string sql = "INSERT INTO [dbo].[User] VALUES (@idUser, @name, @username, @password)";
            using (SqlConnection cnx = new SqlConnection(CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand comando = new SqlCommand(sql, cnx))
                {
                    comando.Parameters.Add(new SqlParameter("@idUser", UsertoCreate.idUser));
                    comando.Parameters.Add(new SqlParameter("@name", UsertoCreate.name));
                    comando.Parameters.Add(new SqlParameter("@username", UsertoCreate.username));
                    comando.Parameters.Add(new SqlParameter("@password", UsertoCreate.password));
                    comando.ExecuteNonQuery();
                }
                cnx.Close();
            }
            CreatedUser = ObtainUser(UsertoCreate.idUser);
            return CreatedUser;
        }

        public Usuario ObtainUser(int idUser)
        {
            Usuario UserFound = null;
            string sql = "SELECT * FROM [dbo].[User] WHERE idUser=@idUser";
            using (SqlConnection conx = new SqlConnection(CadenaConexion))
            {
                conx.Open();
                using (SqlCommand comando = new SqlCommand(sql, conx))
                {
                    comando.Parameters.Add(new SqlParameter("@idUser", idUser));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            UserFound = new Usuario()
                            {
                                idUser = (int)resultado["idUser"],
                                name = (string)resultado["name"],
                                username = (string)resultado["username"],
                                password = (string)resultado["password"],
                            };
                        }
                    }
                }
                conx.Close();
            }
            return UserFound;
        }

        public Usuario ModifyUser(Usuario UsertoModify)
        {
            Usuario UserModified = null;
            string sql = "UPDATE [dbo].[User] SET idUser = @idUser, name = @name, username = @username, password = @password";
            using (SqlConnection conne = new SqlConnection(CadenaConexion))
            {
                {
                    conne.Open();
                    using (SqlCommand comando = new SqlCommand(sql, conne))
                    {
                        comando.Parameters.Add(new SqlParameter("@idUser", UsertoModify.idUser));
                        comando.Parameters.Add(new SqlParameter("@name", UsertoModify.name));
                        comando.Parameters.Add(new SqlParameter("@username", UsertoModify.username));
                        comando.Parameters.Add(new SqlParameter("@password", UsertoModify.password));
                    }
                    conne.Close();
                }
            }
            UserModified = ObtainUser(UsertoModify.idUser);
            return UserModified;
        }

        public void EliminateUser(int IdUser)
        {
            string sql = "DELETE FROM [dbo].[User] WHERE idUser = @idUser";
            using (SqlConnection connex = new SqlConnection(CadenaConexion))
            {
                {
                    connex.Open();
                    using (SqlCommand comando = new SqlCommand(sql, connex))
                    {
                        comando.Parameters.Add(new SqlParameter("@idUser", IdUser));
                        comando.ExecuteNonQuery();
                    }
                    connex.Close();
                }
            }
        }

        public List<Usuario> List()
        {
            List<Usuario> usersFound = new List<Usuario>();
            Usuario userFound = null;
            string sql = "SELECT * FROM [dbo].[User]";
            using (SqlConnection connect = new SqlConnection(CadenaConexion))
            {
                connect.Open();
                using (SqlCommand comando = new SqlCommand(sql, connect))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            userFound = new Usuario()
                            {
                                idUser = (int)resultado["idUser"],
                                name = (string)resultado["name"],
                                username = (string)resultado["username"],
                                password = (string)resultado["password"],
                            };
                            usersFound.Add(userFound);
                        }
                    }
                }
                connect.Close();
            }
            return usersFound;
        }
    }
}
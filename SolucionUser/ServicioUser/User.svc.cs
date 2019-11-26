using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioUser
{
    public class User : IUser
    {        
        private UserDAO userDAO = new UserDAO();
        public Usuario CreateUser(Usuario UsertoCreate)
        {
            if (userDAO.ObtainUser(UsertoCreate.idUser) != null)  //Ya existe//
            {
                throw new FaultException<RepetidoException>(
                  new RepetidoException()
                  {
                      Codigo = "E-101",
                      Descripcion = "El usuario ya existe."
                  },
                  new FaultReason("Error al intentar el empadronamiento"));
            }
            return userDAO.CreateUser(UsertoCreate);
        }

        public Usuario ObtainUser(int idUser)
        {
            return userDAO.ObtainUser(idUser);
        }

        public Usuario ModifyUser(Usuario UsertoModify)
        {
            return userDAO.ModifyUser(UsertoModify);
        }

        public void Eliminateuser(int idUser)
        {
            userDAO.EliminateUser(idUser);
        }        

        public List<Usuario> List()
        {
            return userDAO.List();  
        }
    }
}

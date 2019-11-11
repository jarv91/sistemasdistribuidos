using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSBiblito
{
    public class Service1 : IUser
    {
        private UserController userController = new UserController();
        public User CreateUser(User user)
        {
            if (userController.GetUser(user.username) != null)
            {
                throw new FaultException<BiblitoException>(
                    new BiblitoException() {
                        Code = "101",
                        Description = "Ese username ya existe"
                    }, new FaultReason ("Error al Ingresar username"));
            }
            return userController.CreateUser(user);
        }

        public User GetUser(string username)
        {
            return userController.GetUser(username);
        }
    }
}

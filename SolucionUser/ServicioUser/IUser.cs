using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioUser
{ 
      [ServiceContract]
      public interface IUser
      {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Usuario CreateUser(Usuario UsertoCreate);

        [OperationContract]
        Usuario ObtainUser(int idUser);

        [OperationContract]
        Usuario ModifyUser(Usuario UsertoModify);

        [OperationContract]
        void Eliminateuser(int idUser);

        [OperationContract]
        List<Usuario> List();
      }
}

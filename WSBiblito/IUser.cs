using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSBiblito
{
    [ServiceContract]
    public interface IUser
    {
        [FaultContract(typeof(BiblitoException))]

        [OperationContract]
        User CreateUser(User user);
        [OperationContract]
        User GetUser(string username);
    }
}

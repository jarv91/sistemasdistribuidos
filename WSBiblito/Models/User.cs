using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WSBiblito
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int idUser { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int idUserType { get; set; }
    }
}
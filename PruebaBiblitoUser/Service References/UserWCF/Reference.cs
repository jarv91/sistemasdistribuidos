﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaBiblitoUser.UserWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WSBiblito")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idUserTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idUser {
            get {
                return this.idUserField;
            }
            set {
                if ((this.idUserField.Equals(value) != true)) {
                    this.idUserField = value;
                    this.RaisePropertyChanged("idUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idUserType {
            get {
                return this.idUserTypeField;
            }
            set {
                if ((this.idUserTypeField.Equals(value) != true)) {
                    this.idUserTypeField = value;
                    this.RaisePropertyChanged("idUserType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BiblitoException", Namespace="http://schemas.datacontract.org/2004/07/WSBiblito")]
    [System.SerializableAttribute()]
    public partial class BiblitoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserWCF.IUser")]
    public interface IUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/CreateUser", ReplyAction="http://tempuri.org/IUser/CreateUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PruebaBiblitoUser.UserWCF.BiblitoException), Action="http://tempuri.org/IUser/CreateUserBiblitoExceptionFault", Name="BiblitoException", Namespace="http://schemas.datacontract.org/2004/07/WSBiblito")]
        PruebaBiblitoUser.UserWCF.User CreateUser(PruebaBiblitoUser.UserWCF.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/CreateUser", ReplyAction="http://tempuri.org/IUser/CreateUserResponse")]
        System.Threading.Tasks.Task<PruebaBiblitoUser.UserWCF.User> CreateUserAsync(PruebaBiblitoUser.UserWCF.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        PruebaBiblitoUser.UserWCF.User GetUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        System.Threading.Tasks.Task<PruebaBiblitoUser.UserWCF.User> GetUserAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserChannel : PruebaBiblitoUser.UserWCF.IUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserClient : System.ServiceModel.ClientBase<PruebaBiblitoUser.UserWCF.IUser>, PruebaBiblitoUser.UserWCF.IUser {
        
        public UserClient() {
        }
        
        public UserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PruebaBiblitoUser.UserWCF.User CreateUser(PruebaBiblitoUser.UserWCF.User user) {
            return base.Channel.CreateUser(user);
        }
        
        public System.Threading.Tasks.Task<PruebaBiblitoUser.UserWCF.User> CreateUserAsync(PruebaBiblitoUser.UserWCF.User user) {
            return base.Channel.CreateUserAsync(user);
        }
        
        public PruebaBiblitoUser.UserWCF.User GetUser(string username) {
            return base.Channel.GetUser(username);
        }
        
        public System.Threading.Tasks.Task<PruebaBiblitoUser.UserWCF.User> GetUserAsync(string username) {
            return base.Channel.GetUserAsync(username);
        }
    }
}

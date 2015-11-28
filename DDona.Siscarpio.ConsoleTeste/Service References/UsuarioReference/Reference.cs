﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDona.Siscarpio.ConsoleTeste.UsuarioReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioListagemDTO", Namespace="http://schemas.datacontract.org/2004/07/DDona.Siscarpio.Dto.Usuario")]
    [System.SerializableAttribute()]
    public partial class UsuarioListagemDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UsuarioReference.IUsuario")]
    public interface IUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetAllUsuarios", ReplyAction="http://tempuri.org/IUsuario/GetAllUsuariosResponse")]
        DDona.Siscarpio.ConsoleTeste.UsuarioReference.UsuarioListagemDTO[] GetAllUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetAllUsuarios", ReplyAction="http://tempuri.org/IUsuario/GetAllUsuariosResponse")]
        System.Threading.Tasks.Task<DDona.Siscarpio.ConsoleTeste.UsuarioReference.UsuarioListagemDTO[]> GetAllUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/LogUser", ReplyAction="http://tempuri.org/IUsuario/LogUserResponse")]
        bool LogUser(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/LogUser", ReplyAction="http://tempuri.org/IUsuario/LogUserResponse")]
        System.Threading.Tasks.Task<bool> LogUserAsync(string Username, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioChannel : DDona.Siscarpio.ConsoleTeste.UsuarioReference.IUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioClient : System.ServiceModel.ClientBase<DDona.Siscarpio.ConsoleTeste.UsuarioReference.IUsuario>, DDona.Siscarpio.ConsoleTeste.UsuarioReference.IUsuario {
        
        public UsuarioClient() {
        }
        
        public UsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DDona.Siscarpio.ConsoleTeste.UsuarioReference.UsuarioListagemDTO[] GetAllUsuarios() {
            return base.Channel.GetAllUsuarios();
        }
        
        public System.Threading.Tasks.Task<DDona.Siscarpio.ConsoleTeste.UsuarioReference.UsuarioListagemDTO[]> GetAllUsuariosAsync() {
            return base.Channel.GetAllUsuariosAsync();
        }
        
        public bool LogUser(string Username, string Password) {
            return base.Channel.LogUser(Username, Password);
        }
        
        public System.Threading.Tasks.Task<bool> LogUserAsync(string Username, string Password) {
            return base.Channel.LogUserAsync(Username, Password);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChattingClient.ChatServer {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TrackedFault", Namespace="http://schemas.datacontract.org/2004/07/OptionContract")]
    [System.SerializableAttribute()]
    public partial class TrackedFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid TrackingIdField;
        
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
        public System.DateTime DateAndTime {
            get {
                return this.DateAndTimeField;
            }
            set {
                if ((this.DateAndTimeField.Equals(value) != true)) {
                    this.DateAndTimeField = value;
                    this.RaisePropertyChanged("DateAndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid TrackingId {
            get {
                return this.TrackingIdField;
            }
            set {
                if ((this.TrackingIdField.Equals(value) != true)) {
                    this.TrackingIdField = value;
                    this.RaisePropertyChanged("TrackingId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/OptionContract")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string avartaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int useridField;
        
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
        public string avarta {
            get {
                return this.avartaField;
            }
            set {
                if ((object.ReferenceEquals(this.avartaField, value) != true)) {
                    this.avartaField = value;
                    this.RaisePropertyChanged("avarta");
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
        public int userid {
            get {
                return this.useridField;
            }
            set {
                if ((this.useridField.Equals(value) != true)) {
                    this.useridField = value;
                    this.RaisePropertyChanged("userid");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatMessage", Namespace="http://schemas.datacontract.org/2004/07/OptionContract")]
    [System.SerializableAttribute()]
    public partial class ChatMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CurrentTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderField;
        
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
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CurrentTime {
            get {
                return this.CurrentTimeField;
            }
            set {
                if ((this.CurrentTimeField.Equals(value) != true)) {
                    this.CurrentTimeField = value;
                    this.RaisePropertyChanged("CurrentTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sender {
            get {
                return this.SenderField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderField, value) != true)) {
                    this.SenderField = value;
                    this.RaisePropertyChanged("Sender");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChatServer.IChat", CallbackContract=typeof(ChattingClient.ChatServer.IChatCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/Register", ReplyAction="http://tempuri.org/IChat/RegisterResponse")]
        int Register(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/Login", ReplyAction="http://tempuri.org/IChat/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChattingClient.ChatServer.TrackedFault), Action="http://tempuri.org/IChat/LoginTrackedFaultFault", Name="TrackedFault", Namespace="http://schemas.datacontract.org/2004/07/OptionContract")]
        int Login(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/AddFriend", ReplyAction="http://tempuri.org/IChat/AddFriendResponse")]
        void AddFriend(string username, string Friend);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/CheckOnline", ReplyAction="http://tempuri.org/IChat/CheckOnlineResponse")]
        bool CheckOnline(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/ChangeAvarta", ReplyAction="http://tempuri.org/IChat/ChangeAvartaResponse")]
        void ChangeAvarta(string username, string avarta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/Logout", ReplyAction="http://tempuri.org/IChat/LogoutResponse")]
        void Logout(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetListOnlineFriends", ReplyAction="http://tempuri.org/IChat/GetListOnlineFriendsResponse")]
        ChattingClient.ChatServer.User[] GetListOnlineFriends(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetListOfflineFriends", ReplyAction="http://tempuri.org/IChat/GetListOfflineFriendsResponse")]
        ChattingClient.ChatServer.User[] GetListOfflineFriends(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SendPublicMessage", ReplyAction="http://tempuri.org/IChat/SendPublicMessageResponse")]
        void SendPublicMessage(ChattingClient.ChatServer.ChatMessage CM, string Username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SendPrivateMessage", ReplyAction="http://tempuri.org/IChat/SendPrivateMessageResponse")]
        void SendPrivateMessage(ChattingClient.ChatServer.ChatMessage CM, string To);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/UserLoggedin")]
        void UserLoggedin(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/Userloggedout")]
        void Userloggedout(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/NewPublicMessage")]
        void NewPublicMessage(ChattingClient.ChatServer.ChatMessage CM);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/NewPrivateMessage")]
        void NewPrivateMessage(ChattingClient.ChatServer.ChatMessage CM);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : ChattingClient.ChatServer.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.DuplexClientBase<ChattingClient.ChatServer.IChat>, ChattingClient.ChatServer.IChat {
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Register(string Username, string Password) {
            return base.Channel.Register(Username, Password);
        }
        
        public int Login(string Username, string Password) {
            return base.Channel.Login(Username, Password);
        }
        
        public void AddFriend(string username, string Friend) {
            base.Channel.AddFriend(username, Friend);
        }
        
        public bool CheckOnline(string username) {
            return base.Channel.CheckOnline(username);
        }
        
        public void ChangeAvarta(string username, string avarta) {
            base.Channel.ChangeAvarta(username, avarta);
        }
        
        public void Logout(string username) {
            base.Channel.Logout(username);
        }
        
        public ChattingClient.ChatServer.User[] GetListOnlineFriends(string username) {
            return base.Channel.GetListOnlineFriends(username);
        }
        
        public ChattingClient.ChatServer.User[] GetListOfflineFriends(string username) {
            return base.Channel.GetListOfflineFriends(username);
        }
        
        public void SendPublicMessage(ChattingClient.ChatServer.ChatMessage CM, string Username) {
            base.Channel.SendPublicMessage(CM, Username);
        }
        
        public void SendPrivateMessage(ChattingClient.ChatServer.ChatMessage CM, string To) {
            base.Channel.SendPrivateMessage(CM, To);
        }
    }
}

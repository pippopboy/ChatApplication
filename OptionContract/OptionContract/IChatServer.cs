using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OptionContract
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int userid;
        
        [DataMember]
        public string username;
        
        [DataMember]
        public string password;

        [DataMember]
        public string avarta;
    }

    [DataContract]
    public class ChatMessage
    {
        [DataMember]
        public string Sender;

        [DataMember]
        public string Content;

        [DataMember]
        public DateTime CurrentTime;
    }

    [DataContract]
    public class TrackedFault
    {
        #region Private fields
        private Guid _trackingId;
        private string _name;
        private string _details;
        private DateTime _dateTime;
        #endregion

        #region Properties
        [DataMember]
        public Guid TrackingId
        {
            get { return _trackingId; }
            set { _trackingId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        [DataMember]
        public DateTime DateAndTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
        #endregion

        public TrackedFault(Guid id, string name, string details, DateTime dateTime)
        {
            _name = name;
            _trackingId = id;
            _details = details;
            _dateTime = dateTime;
        }
    }

    [ServiceContract(CallbackContract=typeof(IChatCallBack), SessionMode = SessionMode.Required)]
    public interface IChat
    {
        [OperationContract]
        int Register(string Username, string Password);

        [OperationContract]
        [FaultContract(typeof(TrackedFault))]
        int Login(string Username, string Password);

        [OperationContract]
        void AddFriend(string username, string Friend);

        [OperationContract]
        bool CheckOnline(string username);

        [OperationContract]
        void ChangeAvarta(string username, string avarta);

        [OperationContract]
        void Logout(string username);

        [OperationContract]
        List<User> GetListOnlineFriends(string username);

        [OperationContract]
        List<User> GetListOfflineFriends(string username);

        [OperationContract]
        void SendPublicMessage(ChatMessage CM, string Username);

        [OperationContract]
        void SendPrivateMessage(ChatMessage CM, string To);

    }

    public interface IChatCallBack
    {
        [OperationContract(IsOneWay = true)]
        void UserLoggedin(string name);

        [OperationContract(IsOneWay = true)]
        void Userloggedout(string name);

        [OperationContract(IsOneWay = true)]
        void NewPublicMessage(ChatMessage CM);

        [OperationContract(IsOneWay = true)]
        void NewPrivateMessage(ChatMessage CM);
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using OptionContract;

namespace OptionContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple,
        UseSynchronizationContext = false, IncludeExceptionDetailInFaults = true)]
    
    public class ChatServer: IChat
    {
        private Dictionary<string, IChatCallBack> ClientCallBacks = new Dictionary<string, IChatCallBack>();
        private ChatDBDataContext DB = new ChatDBDataContext();
        static object syncObj = new object();
        public IChatCallBack CurrentCallback
        {
            get { return OperationContext.Current.GetCallbackChannel<IChatCallBack>(); }
        }

        #region CheckOnlineListFriend
        private void CheckOnlineListFriends(string username)
        {
            lock (syncObj)
            {
                List<User> listonline = this.GetListOnlineFriends(username);
                foreach (User useronline in listonline)
                {
                    ClientCallBacks[useronline.username].UserLoggedin(username);
                }
            }
        }
        #endregion 

        #region CheckOnline
        //Check an user online or not
        public bool CheckOnline(string username)
        {
            if (ClientCallBacks.ContainsKey(username))
            {
                return true;
            }
            return false;
        }
	
        #endregion

        #region Register
        public int Register(string Username, string Password)
        {
            //ChatDBDataContext DB = new ChatDBDataContext();
            var Users = from U in DB.users
                        where U.username == Username && U.password == Password
                        select U;
            foreach (user user in Users)
            {
                return 0;
            }

            user NewUser = new user();
            NewUser.username = Username;
            NewUser.password = Password;
            DB.users.InsertOnSubmit(NewUser);
            DB.SubmitChanges();
            return 1;
        }
        #endregion

        #region Login
        public int Login(string Username, string Password)
        {
            int exist = 0;

            lock (syncObj)
            {
                var existusers = (from u in DB.users
                                 where u.username == Username
                                 select u).Single();
                if (existusers!=null)
                {
                    exist = 1;
                }

                var Users = from U in DB.users
                             where U.username == Username && U.password == Password
                             select U;
                if (Users.Count() == 0)
                {

                    if (exist == 1)
                    {
                        TrackedFault trackedFault = new TrackedFault(Guid.NewGuid(), Username, "Password is incorrect!", DateTime.Now);
                        throw new FaultException<TrackedFault>(trackedFault, "Password isn't correct", FaultCode.CreateReceiverFaultCode(new FaultCode("Login")));
                        return 2;
                    }
                    else
                    {
                        throw new Exception("Tên đăng nhập hoặc mật khẩu không đúng! Thử lại!");
                        return 2;
                    }
                }
                else
                {
                    //Username da dang nhap nen co trong danh sach callback
                    if (ClientCallBacks.ContainsKey(Username))
                        return 0;
                    else
                    {
                        CheckOnlineListFriends(Username);
                        ClientCallBacks.Add(Username, CurrentCallback);
                        return 1;
                    }
                }
            }
        }
        #endregion

        #region GetFriend
        private int GetFriend(string Username, string Friend)
        {
            User NewUser = this.GetUserByUsername(Username);
            User NewFriend = this.GetUserByUsername(Username);

            var Friends = from R in DB.Relations
                         where R.Userid == NewUser.userid && R.FriendId == NewFriend.userid
                         select R;

            foreach (Relation rl in Friends)
            {
                return 1;
            }
            return 0;
        }
        #endregion

        #region AddFriend
        public void AddFriend(string Username, string Friend)
        {
            User NewUser = this.GetUserByUsername(Username);
            User NewFriend = this.GetUserByUsername(Friend);
            Relation RL = new Relation();
            RL.Userid = NewUser.userid;
            RL.FriendId = NewFriend.userid;
            DB.Relations.InsertOnSubmit(RL);
            DB.SubmitChanges();

            Relation RL1 = new Relation();
            RL1.Userid = NewFriend.userid;
            RL1.FriendId = NewUser.userid;
            DB.Relations.InsertOnSubmit(RL1);
            DB.SubmitChanges();
            if (ClientCallBacks.ContainsKey(Friend))
            {
                ClientCallBacks[Friend].UserLoggedin(Username);
            }
        }
        #endregion

        #region ChangeAvarta
        public void ChangeAvarta(string username, string avarta)
        {
            var change = (from U in DB.users
                         where U.username == username
                         select U).Single();
            change.avarta = avarta;
            DB.SubmitChanges();
        }
        #endregion

        #region LogOut
        public void Logout(string Username)
        {
            List<User> listuser = new List<User>();
            if (ClientCallBacks.ContainsKey(Username))
            {
                ClientCallBacks.Remove(Username);
                listuser = this.GetListOnlineFriends(Username);
                foreach (User user in listuser)
                {
                    ClientCallBacks[user.username].Userloggedout(Username);
                }
            }
        }
        #endregion

        #region GetUserById
        private User GetUserById(int userid)
        {
            User NewUser = new User();
            var Users = from U in DB.users
                        where U.userid == userid
                        select U;
            foreach (user user in Users)
            {
                NewUser.userid = user.userid;
                NewUser.username = user.username;
                NewUser.password = user.password;
                NewUser.avarta = user.avarta;
            }
            return NewUser;
        }
        #endregion

        #region GetUserByUserName
        private User GetUserByUsername(string Username)
        {
            User NewUser = new User();
            var Users = (from U in DB.users
                        where U.username == Username
                        select U).Distinct();
            foreach (user user in Users)
            {
                NewUser.userid = user.userid;
                NewUser.username = user.username;
                NewUser.password = user.password;
                NewUser.avarta = user.avarta;
            }
            return NewUser;
        }
        #endregion

        #region GetListFriends
        public int GetlistFriend(string Username, string Friend)
        {
            User NewUser = this.GetUserByUsername(Username);
            User NewFriend = this.GetUserByUsername(Username);

            var Friends = from R in DB.Relations
                          where R.Userid == NewUser.userid && R.FriendId == NewFriend.userid
                          select R;

            foreach (Relation rl in Friends)
            {
                return 1;
            }
            return 0;
        }
        #endregion
        
        #region GetListOnlineFriends
        public List<User> GetListOnlineFriends(string username)
        {
            lock (syncObj)
            {

                List<User> UL = new List<User>();
                User NewUser = this.GetUserByUsername(username);
                var Friends = (from R in DB.Relations
                               where R.Userid == NewUser.userid
                               select R).Distinct();
                foreach (Relation Friend in Friends)
                {
                    User FriendData = this.GetUserById(Friend.FriendId);
                    if (ClientCallBacks.ContainsKey(FriendData.username))
                    {
                        UL.Add(FriendData);
                    }
                }
                return UL;
            }

        }
        #endregion

        #region GetListOfflineFriends
        public List<User> GetListOfflineFriends(string username)
        {
            List<User> UL = new List<User>();
            //ChatDBDataContext DB = new ChatDBDataContext();
            User NewUser = this.GetUserByUsername(username);
            var Friends = from R in DB.Relations
                          where R.Userid == NewUser.userid
                          select R;
            foreach (Relation Friend in Friends)
            {
                User FriendData = this.GetUserById(Friend.FriendId);
                if (!ClientCallBacks.ContainsKey(FriendData.username))
                {
                    UL.Add(FriendData);
                }
            }
            return UL;
        }
        #endregion

        #region Send a public Message
        public void SendPublicMessage(ChatMessage CM, string Username)
        {
            foreach (KeyValuePair<string, IChatCallBack> pair in ClientCallBacks)
            {
                if (pair.Key != Username)
                    ClientCallBacks[pair.Key].NewPublicMessage(CM);
            }
            
            //List<User> online = GetListOnlineFriends(To);
            //foreach (User user in online)
            //{
            //    ClientCallBacks[user.username].NewMessage(CM);
            //}
        }
       #endregion

        #region Send a private message
		public void SendPrivateMessage(ChatMessage CM, string To)
		{
            if (ClientCallBacks.ContainsKey(To))
            {
                ClientCallBacks[To].NewPrivateMessage(CM);
            }
		}

        #endregion
    }
}

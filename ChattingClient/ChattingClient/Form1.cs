using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ServiceModel;
using ChattingClient.ChatServer;


namespace ChattingClient
{
  
    public partial class Form1 : Form, IChatCallback
    {
        public ChatClient proxy;
        //NetTcpBinding ws = new NetTcpBinding(SecurityMode.None);
        WSDualHttpBinding ws = new WSDualHttpBinding(WSDualHttpSecurityMode.Message);
        EndpointAddress address = new EndpointAddress("http://localhost:8000/Chat/");
        private string ToUser;
        public string message;
       
        public Form1()
        {
            InitializeComponent();
            //proxy = DuplexChannelFactory<IChat>.CreateChannel(this, ws, address);
            //proxy = new ChatClient(new InstanceContext(this), ws, address);
        }

        public void UserLoggedin(string name)
        {
            lbfriend.Items.Add(name);
            //listBox2.Items.Remove(name);
        }

        public void Userloggedout(string name)
        {
            //listBox2.Items.Add(name);
            lbfriend.Items.Remove(name);  
        }

        public void NewPublicMessage(ChatMessage CM)
        {
            AppendText(RTBRoom, Color.Black, CM.Content);
            RTBRoom.SelectionStart = RTBRoom.Text.Length;
            RTBRoom.ScrollToCaret();
            
        }

        public void NewPrivateMessage(ChatMessage CM)
        {
            AppendText(RTBRoom, Color.Blue, CM.Content);
            AppendText(RTBPrivate, Color.Blue, CM.Content);
            RTBPrivate.SelectionStart = RTBPrivate.Text.Length;
            RTBPrivate.ScrollToCaret();
            RTBRoom.SelectionStart = RTBRoom.Text.Length;
            RTBRoom.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Click button Send
            
            //proxy = DuplexChannelFactory<IChat>.CreateChannel(this, ws, address);
            proxy = new ChatClient(new InstanceContext(this), ws, address);
            try
            {
                int check = proxy.Login(txtusername.Text, txtpassword.Text);
                if (check == 1)
                {
                    //banbe bb = new banbe();
                    MessageBox.Show("Log in successfully");
                    User[] user = proxy.GetListOnlineFriends(txtusername.Text);
                    List<User> listonline = user.ToList<User>();
                    foreach (User online in listonline)
                    {
                        if (!lbfriend.Items.Contains(online.username))
                        {
                            lbfriend.Items.Add(online.username);
                        }
                    }
                    label3.Text = "Wellcome " + txtusername.Text + " to Yahoo.";
                    label3.Visible = true;
                    groudLogin.Enabled = false;
                    groupInfor.Visible = true;
                }
            }
            catch (FaultException<TrackedFault>  ex)
            {
                LinkLabel label = new LinkLabel();
                label.Text = ex.Detail.TrackingId.ToString();
                DialogResult result = MessageBox.Show("Không thể truy cập. Lỗi: " + ex.Detail.TrackingId + "\n Bạn có muốn xem lỗi???", ex.GetType().ToString(), MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(ex.Detail.Details);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, exp.GetType().ToString());
            }
           

        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbfriend.SelectedIndex >= 0)
            {
                ToUser = lbfriend.Items[lbfriend.SelectedIndex].ToString();   
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Send();
        }

        void Send()
        {
           
            if (RTBText.Text == string.Empty)
            {
                MessageBox.Show("Tin nhắn rỗng. Thử lại!");
            }
            else
            {
                ChatMessage CM = new ChatMessage();
                CM.Sender = txtusername.Text;
                CM.Content = " " + txtusername.Text + " : " + RTBText.Text + "\n";
                CM.CurrentTime = DateTime.Now;
                if (cbChatMat.Checked)
                {
                    AppendText(RTBPrivate, Color.Blue, CM.Content);
                    AppendText(RTBRoom, Color.Blue, CM.Content);
                    RTBPrivate.SelectionStart = RTBPrivate.Text.Length;
                    RTBPrivate.ScrollToCaret();
                    RTBRoom.SelectionStart = RTBRoom.Text.Length;
                    RTBRoom.ScrollToCaret();
                    proxy.SendPrivateMessage(CM, ToUser);
                }
                else
                {
                    AppendText(RTBRoom, Color.Black, CM.Content);
                    RTBRoom.SelectionStart = RTBRoom.Text.Length;
                    RTBRoom.ScrollToCaret();
                    proxy.SendPublicMessage(CM, CM.Sender);
                }
            }
            RTBText.Select(0,RTBText.TextLength);
            RTBText.SelectedText = "";
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btAddFriend_Click(object sender, EventArgs e)
        {
            proxy.AddFriend(txtusername.Text, txtAddFriend.Text);
            if (proxy.CheckOnline(txtAddFriend.Text))
            {
                lbfriend.Items.Add(txtAddFriend.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stream strm = null;
            try
            {
                OpenFileDialog fileDialog= new OpenFileDialog();
                fileDialog.Multiselect = false;
                strm = fileDialog.OpenFile();
                if (strm != null)
                {
                    byte[] buffer = new byte[(int)strm.Length];
                    int i = strm.Read(buffer, 0, buffer.Length);
                    if (i > 0)
                    {
                        
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;
            box.Select(start, end-start);
            box.SelectionColor = color;
            box.SelectionLength = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send();
            }
        }

        private void RTBText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ModifierKeys == Keys.Control)
            {
                Send();
                e.Handled = true;
            }
        }


    }
}

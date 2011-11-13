namespace ChattingClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLogin = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbfriend = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RTBRoom = new System.Windows.Forms.RichTextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groudLogin = new System.Windows.Forms.GroupBox();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.btAddFriend = new System.Windows.Forms.Button();
            this.txtAddFriend = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RTBPrivate = new System.Windows.Forms.RichTextBox();
            this.cbChatMat = new System.Windows.Forms.CheckBox();
            this.RTBText = new System.Windows.Forms.TextBox();
            this.groudLogin.SuspendLayout();
            this.groupInfor.SuspendLayout();
            this.ChatBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(212, 22);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(103, 50);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Log in";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(67, 22);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(139, 20);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(67, 51);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(139, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lbfriend
            // 
            this.lbfriend.FormattingEnabled = true;
            this.lbfriend.Location = new System.Drawing.Point(12, 147);
            this.lbfriend.Name = "lbfriend";
            this.lbfriend.Size = new System.Drawing.Size(162, 277);
            this.lbfriend.TabIndex = 3;
            this.lbfriend.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbfriend.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // RTBRoom
            // 
            this.RTBRoom.AcceptsTab = true;
            this.RTBRoom.Location = new System.Drawing.Point(6, 3);
            this.RTBRoom.Name = "RTBRoom";
            this.RTBRoom.Size = new System.Drawing.Size(398, 260);
            this.RTBRoom.TabIndex = 7;
            this.RTBRoom.Text = "";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(511, 418);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(68, 61);
            this.btSend.TabIndex = 9;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your New Message: ";
            this.label4.Visible = false;
            // 
            // groudLogin
            // 
            this.groudLogin.Controls.Add(this.label1);
            this.groudLogin.Controls.Add(this.label2);
            this.groudLogin.Controls.Add(this.txtusername);
            this.groudLogin.Controls.Add(this.txtpassword);
            this.groudLogin.Controls.Add(this.btLogin);
            this.groudLogin.Location = new System.Drawing.Point(19, 16);
            this.groudLogin.Name = "groudLogin";
            this.groudLogin.Size = new System.Drawing.Size(339, 100);
            this.groudLogin.TabIndex = 11;
            this.groudLogin.TabStop = false;
            this.groudLogin.Text = "Đăng nhập";
            
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(this.btAddFriend);
            this.groupInfor.Controls.Add(this.txtAddFriend);
            this.groupInfor.Controls.Add(this.label3);
            this.groupInfor.Location = new System.Drawing.Point(379, 16);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Size = new System.Drawing.Size(200, 100);
            this.groupInfor.TabIndex = 12;
            this.groupInfor.TabStop = false;
            this.groupInfor.Text = "Thông Tin User";
            this.groupInfor.Visible = false;
            // 
            // btAddFriend
            // 
            this.btAddFriend.Location = new System.Drawing.Point(119, 61);
            this.btAddFriend.Name = "btAddFriend";
            this.btAddFriend.Size = new System.Drawing.Size(75, 23);
            this.btAddFriend.TabIndex = 8;
            this.btAddFriend.Text = "Kết Bạn";
            this.btAddFriend.UseVisualStyleBackColor = true;
            this.btAddFriend.Click += new System.EventHandler(this.btAddFriend_Click);
            // 
            // txtAddFriend
            // 
            this.txtAddFriend.Location = new System.Drawing.Point(6, 64);
            this.txtAddFriend.Name = "txtAddFriend";
            this.txtAddFriend.Size = new System.Drawing.Size(100, 20);
            this.txtAddFriend.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Send File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ChatBox
            // 
            this.ChatBox.Controls.Add(this.tabPage1);
            this.ChatBox.Controls.Add(this.tabPage2);
            this.ChatBox.Location = new System.Drawing.Point(182, 123);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.SelectedIndex = 0;
            this.ChatBox.Size = new System.Drawing.Size(415, 289);
            this.ChatBox.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RTBRoom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RTBPrivate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chat Mật";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RTBPrivate
            // 
            this.RTBPrivate.Location = new System.Drawing.Point(6, 3);
            this.RTBPrivate.Name = "RTBPrivate";
            this.RTBPrivate.Size = new System.Drawing.Size(396, 258);
            this.RTBPrivate.TabIndex = 8;
            this.RTBPrivate.Text = "";
            // 
            // cbChatMat
            // 
            this.cbChatMat.AutoSize = true;
            this.cbChatMat.Location = new System.Drawing.Point(12, 124);
            this.cbChatMat.Name = "cbChatMat";
            this.cbChatMat.Size = new System.Drawing.Size(134, 17);
            this.cbChatMat.TabIndex = 15;
            this.cbChatMat.Text = "Chat mật ( Chọn người)";
            this.cbChatMat.UseVisualStyleBackColor = true;
            // 
            // RTBText
            // 
            this.RTBText.Location = new System.Drawing.Point(180, 418);
            this.RTBText.Multiline = true;
            this.RTBText.Name = "RTBText";
            this.RTBText.Size = new System.Drawing.Size(325, 61);
            this.RTBText.TabIndex = 16;
            this.RTBText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RTBText_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 515);
            this.Controls.Add(this.RTBText);
            this.Controls.Add(this.cbChatMat);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.groudLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.lbfriend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groudLogin.ResumeLayout(false);
            this.groudLogin.PerformLayout();
            this.groupInfor.ResumeLayout(false);
            this.groupInfor.PerformLayout();
            this.ChatBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTBRoom;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox lbfriend;
        private System.Windows.Forms.GroupBox groudLogin;
        private System.Windows.Forms.GroupBox groupInfor;
        private System.Windows.Forms.Button btAddFriend;
        private System.Windows.Forms.TextBox txtAddFriend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl ChatBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox RTBPrivate;
        private System.Windows.Forms.CheckBox cbChatMat;
        private System.Windows.Forms.TextBox RTBText;
    }
}


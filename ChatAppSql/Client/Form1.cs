using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using Server;
using Server.Models;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    public partial class FormClient : Form
    {
        private readonly Registration registration;
        private readonly Repository repository;
        private readonly Users chatWindow;
        private static int statusCode;
        private static string title = "Login";
        private static string message;

        public FormClient()
        {
            InitializeComponent();
            registration = new Registration();
            repository = new Repository();
            chatWindow = new Users();
        }
        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUserName.TextName.Length != 0 && textPassword.TextName.Length != 0)
                {
                    LoginRequest loginDetails = new LoginRequest
                    {
                        UserName = textUserName.TextName,
                        Password = textPassword.TextName
                    };
                    statusCode = repository.Login(loginDetails);
                    if (statusCode == -1)
                    {
                        message = "No User present with this Email!";
                        MessageBox.Show(message, title);
                    }
                    else if (statusCode == 0)
                    {
                        this.Hide();
                        chatWindow.SetUserName(textUserName.TextName);
                        chatWindow.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registration.Show();
        }
    }
}

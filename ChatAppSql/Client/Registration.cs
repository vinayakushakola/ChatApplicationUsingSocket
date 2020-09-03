using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
using Server.Models;

namespace Client
{
    public partial class Registration : Form
    {
        private static string message;
        private static string title = "Registration";
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistrationRequest userDetails = new RegistrationRequest
            {
                FirstName = textFirstName.TextName,
                LastName = textLastName.TextName,
                Email = textEmail.TextName,
                UserName = textUserName.TextName,
                Password = textPassword.TextName
            };
            Repository repository = new Repository();
            int statusCode = repository.Registration(userDetails);
            if(statusCode == -1)
            {
                message = "Email already exists!";
                MessageBox.Show(message, title);
            }
            else if(statusCode == -2)
            {
                message = "User Name already taken!";
                MessageBox.Show(message, title);
            }
            else if (statusCode == 0)
            {
                message = "Registration Successfull";
                MessageBox.Show(message, title);
                this.Hide();
                FormClient client = new FormClient();
                client.Show();
            }
            else
            {
                message = "Registration Unsuccessfull";
                MessageBox.Show(message, title);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

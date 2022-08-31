using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserLoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpPortal objUI = new SignUpPortal();
            objUI.ShowDialog();
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = "Ahmet Burak";
            user.surName = "Zaloğlu";
            user.email = "aburak1104@hotmail.com";
            user.userName = "aburak1104";
            user.password = "123456";

            if(txtPassword.Text !=  user.password || txtUserName.Text != user.userName)
            {
                MessageBox.Show("Your Credentials aren't matching try again");
            }
            else
            {
                MessageBox.Show(user.Logged(user.name,user.surName));
            }

        }
    }
}

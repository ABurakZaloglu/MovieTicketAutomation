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
    public partial class SignUpPortal : Form
    {
        public SignUpPortal()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = txtName.Text;
            user.surName = txtSurName.Text;
            user.email = txtEmail.Text;
            user.userName = txtUserName.Text;
            user.password = txtPassword.Text;
            MessageBox.Show(user.NewLog(user.name, user.surName, user.email, user.userName, user.password));
        }
    }
}

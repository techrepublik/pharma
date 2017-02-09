using System;
using System.Drawing;
using System.Windows.Forms;
using PharmaPos.data;
using PharmaPos.dal.man;

namespace PharmaPos
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if ((waterMarkTextBoxUser.Text.Length > 0) && (waterMarkTextBoxPassword.Text.Length > 0))
            {
                var user = GetUser(waterMarkTextBoxUser.Text, waterMarkTextBoxPassword.Text);
                if (user != null)
                {
                    var f = new MainForm {User = user};
                    f.Show();
                    Hide();
                }
                else
                {
                    labelMessage.Text = @"Invalid User Account. Please verify account and try again.";
                    labelMessage.ForeColor = Color.Red;
                }
            }
        }

        private User GetUser(string username, string password)
        {
            var user = new User();
            if ((username.Length <= 0) || (password.Length <= 0)) return user;
            try
            {
                user = UserManager.GetUser(username, password);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
            return user;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

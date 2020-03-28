using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassanFoods
{
    public partial class Login : Form
    {
        List<Users> users;
        bool check =false;

        public Login()
        {
            InitializeComponent();
            users = new List<Users>();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string name = TextBoxUserName.Text;
            string password = TextBoxPassword.Text;
            IOManager.ReadData(users);

            for(int i=0;i< users.Count;i++)
            {
                if(users[i].name == name && users[i].password == password)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    check = true;
                }
            }
            if (check == false)
                MessageBox.Show("invalid username or password");
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to close this application?";
            string header = "Alert!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, header,buttons);
            if(result.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }

        }
        private void lblforgotpass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            string message = "you forgot your password?";
            string header = "Alert!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result= MessageBox.Show(message, header,buttons);
            if(result.Equals(DialogResult.Yes))
            {
                forgotPassword.Show();
                this.Hide();
            }
        }

        private void TextBoxUserName_Enter(object sender, EventArgs e)
        {
            TextBoxUserName.Text = "";
        }
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            TextBoxPassword.Text = "";
            TextBoxPassword.PasswordChar = Convert.ToChar("*");
        }
    }
}

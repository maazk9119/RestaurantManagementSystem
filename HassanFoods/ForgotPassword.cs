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
    public partial class ForgotPassword : Form
    {
        int count = 0;
        public ForgotPassword()
        {
            InitializeComponent();
            lblusername.Text.Equals("");
            lblpass.Text.Equals("");
            lblerepass.Text.Equals("");
            textBoxUserName.Enabled = false;
            textBoxPass.Enabled = false;
            textBoxRePass.Enabled = false;
            BtnOk.Enabled = false;
        }

        private void BtnOKValid_Click(object sender, EventArgs e)
        {
            if (textBoxPincode.Text == "03120012425")
            {
                lblusername.Text.Equals("New Username");
                lblpass.Text.Equals("New password");
                lblerepass.Text.Equals("Re-Write password");
                count = 0;
                BtnOk.Enabled = true;
                textBoxUserName.Enabled = true;
                textBoxPass.Enabled = true;
                textBoxRePass.Enabled = true;
                textBoxPincode.Enabled = false;
                BtnOKValid.Enabled = false;
            }
            else
            {
                count++;
                CountCheck();
                MessageBox.Show("Enter PIN CODE");
            }
        }   
        private void CountCheck()
        {
            if (count == 4)
                Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if((textBoxUserName.Text)==""|| (textBoxRePass.Text) ==""||(textBoxPass.Text)=="")
            {
                MessageBox.Show("Fill All requirment");
            }
            else
            {
                if(textBoxPass.Text == textBoxRePass.Text)
                {
                    IOManager.MakeFile("03120012425.txt", textBoxUserName.Text, textBoxPass.Text);
                    string message = "you username and password is reset!";
                    string header = "THANK YOU!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, header, buttons);
                    if(result.Equals(DialogResult.Yes))
                    {
                        Login l = new Login();
                        l.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("enter same re-write password");
                }
            }

        }
        private void lblpincode_Click(object sender, EventArgs e)
        {

        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

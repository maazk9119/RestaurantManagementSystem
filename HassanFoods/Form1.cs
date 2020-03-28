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
    public partial class Form1 : Form
    {
        public static string var;
        public static string var1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control(HomeUserControl.Instance);
            var = DateTime.Now.ToLongTimeString();
            var1 = DateTime.Now.ToLongDateString();
            
            //IOManager.MakeFile("Rools.txt");
        }

        //Method (Buttons) show on screen
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Control(HomeUserControl.Instance);
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Control(OrderUserControl.Instance);
        }
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            Control(AddItemUserControl.Instance);
        }
        private void BtnViewItems_Click(object sender, EventArgs e)
        {
            Control(ViewItemsUserControl.Instance);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //method made by my self for code reusibility 
        public void Control(Control control)
        {
            if (!panelusercontrols.Controls.Contains(control))
            {
                panelusercontrols.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();
            }
            else
            {
                control.BringToFront();
            }
        }

        
    }
}

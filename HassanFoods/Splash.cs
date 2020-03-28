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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        
        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelyellowline.Width += 6;
            if (panelyellowline.Width >= 409)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
}
}

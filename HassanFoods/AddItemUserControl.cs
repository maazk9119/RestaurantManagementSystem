using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassanFoods
{
    public partial class AddItemUserControl : UserControl
    {
        private static AddItemUserControl _instance;
        public static AddItemUserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new AddItemUserControl();
                }
                return _instance;
            }
        }

        //Deafult constructor
        public AddItemUserControl()
        {
            InitializeComponent();
        }
        
        //All method (Buttons on screen)
        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            string check = comboBoxItemtype.Text;
            string Name = textBoxFoodName.Text;
            int price = int.Parse(textBoxPrice.Text);

            if (textBoxFoodName.Text != "" && textBoxPrice.Text != "" && comboBoxItemtype.Text != "")
            {
                if (check.Equals("Burgers"))
                {
                    AddItems("Burgers.txt", Name, price);
                }
                else if (check.Equals("DesiBurgers"))
                {
                    AddItems("DesiBurgers.txt", Name, price);
                }
                else if (check.Equals("Fries"))
                {
                    AddItems("Fries.txt", Name, price);
                }
                else if (check.Equals("Rolls"))
                {
                    AddItems("Rolls.txt", Name, price);
                }
                else if (check.Equals("Sandwiches"))
                {
                    AddItems("Sandwiches.txt", Name, price);
                }
                else if (check.Equals("Chatpata"))
                {
                    AddItems("Chatpata.txt", Name, price);
                }
                else if (check.Equals("Icecream"))
                {
                    AddItems("Icecream.txt", Name, price);
                }
                else if (check.Equals("Broast"))
                {
                    AddItems("Broast.txt", Name, price);
                }
                else if (check.Equals("Drinks"))
                {
                    AddItems("Drinks.txt", Name, price);
                }
                else if(check.Equals("Others"))
                {
                    AddItems("Others.txt", Name, price);
                }
            }
            else
            {
                MessageBox.Show("Fill All", "Alert");
            }
            
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string check = comboBoxItemtype.Text;
            string Name = textBoxFoodName.Text;
            int price = int.Parse(textBoxPrice.Text);
            if (textBoxFoodName.Text != "" && textBoxPrice.Text != "" && comboBoxItemtype.Text != "" && int.Parse(textBoxPrice.Text) != 0)
            {
                if (check.Equals("Burgers"))
                {
                    UpdateItems("Burgers.txt", Name, price);
                }
                else if (check.Equals("DesiBurgers"))
                {
                    UpdateItems("DesiBurgers.txt", Name, price);
                }
                else if (check.Equals("Fries"))
                {
                    UpdateItems("Fries.txt", Name, price);
                }
                else if (check.Equals("Rolls"))
                {
                    UpdateItems("Rolls.txt", Name, price);
                }
                else if (check.Equals("Sandwiches"))
                {
                    UpdateItems("Sandwiches.txt", Name, price);
                }
                else if (check.Equals("Chatpata"))
                {
                    UpdateItems("Chatpata.txt", Name, price);
                }
                else if (check.Equals("Icecream"))
                {
                    UpdateItems("Icecream.txt", Name, price);
                }
                else if (check.Equals("Broast"))
                {
                    UpdateItems("Broast.txt", Name, price);
                }
                else if (check.Equals("Drinks"))
                {
                    UpdateItems("Drinks.txt", Name, price);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!", "ALERT");
            }
        }
        
        //method made by myself for code reusibility
        private void AddItems(string Path,string Name, int price)
        {
            string message = "Do you want to add this item?";
            string title = "ADD ITEM";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes )
            {
                bool aa=IOManager.MakeFile(Path, Name, price);
                if (aa)
                {
                    string message1 = "Your given item has been added";
                    string title1 = "ADD ITEM";
                    MessageBox.Show(message1, title1);
                    ClearAll();
                }
                else
                {
                    string message1 = "Your given item has not been added";
                    string title1 = "ALERT!";
                    MessageBox.Show(message1, title1);
                    ClearAll();
                }
            }
        }
        private void UpdateItems(string Path, string Name, int price)
        {
            string message = "Do you want to update this item?";
            string title = "UPDATE ITEM";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                bool aa = IOManager.Update(Path, Name, price);
                if (aa)
                {
                    string message1 = "Your given item has been update";
                    string title1 = "UPDATE ITEM";
                    MessageBox.Show(message1, title1);
                    ClearAll();
                }
                else
                {
                    string message1 = "Your given item has not been update";
                    string title1 = "ALERT!";
                    MessageBox.Show(message1, title1);
                    ClearAll();
                }
            }
        }
        private void ClearAll()
        {
            comboBoxItemtype.Text = "";
            textBoxFoodName.Clear();
            textBoxPrice.Clear();
        }
       
    }
}

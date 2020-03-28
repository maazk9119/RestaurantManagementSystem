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
    public partial class ViewItemsUserControl : UserControl
    {
        
        DataTable dataTable = new DataTable();
        List<Burgers> burgers = new List<Burgers>();
        List<DesiBurgers> desiBurgers = new List<DesiBurgers>();
        List<Fries> fries = new List<Fries>();
        List<Drinks> drinks = new List<Drinks>();
        List<Sandwiches> sandwiches = new List<Sandwiches>();
        List<Chatpata> chatpatas = new List<Chatpata>();
        List<IceCream> iceCreams = new List<IceCream>();
        List<Broast> broasts = new List<Broast>();
        List<Rolls> rolls = new List<Rolls>();
        List<Others> others = new List<Others>();

        private static ViewItemsUserControl _instance;
        public static ViewItemsUserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ViewItemsUserControl();
                }
                return _instance;
            }
        }
        public ViewItemsUserControl()
        {
            InitializeComponent();
        }

        private void ViewItemsUserControl_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("FOOD NAME", typeof(string));
            dataTable.Columns.Add("PRICE", typeof(string));
            dataGridView1.DataSource = dataTable;

            // or whatever width works well for abbrev
            
        }

        private void comboBoxItemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string check = comboBoxItemtype.Text;
            comboBoxItemtype.Text = "";
            burgers.Clear();
            desiBurgers.Clear();
            broasts.Clear();
            rolls.Clear();
            fries.Clear();
            drinks.Clear();
            sandwiches.Clear();
            chatpatas.Clear();
            iceCreams.Clear();
            others.Clear();
            if (check.Equals("Burgers"))
            {
                IOManager.ReadData("Burgers.txt", burgers);
                AddtoGrid(burgers);
            }
            else if(check.Equals("DesiBurgers"))
            {
                IOManager.ReadData("DesiBurgers.txt", desiBurgers);
                AddtoGrid(desiBurgers);
            }
            else if(check.Equals("Rolls"))
            {
                IOManager.ReadData("Rools.txt", rolls);
                AddtoGrid(rolls);
            }
            else if (check.Equals("Fries"))
            {
                IOManager.ReadData("Fries.txt", fries);
                AddtoGrid(fries);
            }
            else if (check.Equals("Sandwiches"))
            {
                IOManager.ReadData("Sandwiches.txt", sandwiches);
                AddtoGrid(sandwiches);
            }
            else if (check.Equals("Icecream"))
            {
                IOManager.ReadData("Icecream.txt", iceCreams);
                AddtoGrid(iceCreams);
            }
            else if (check.Equals("Chatpata"))
            {
                IOManager.ReadData("Chatpata.txt", chatpatas);
                AddtoGrid(chatpatas);
            }
            else if (check.Equals("Broast"))
            {
                IOManager.ReadData("Broast.txt", broasts);
                AddtoGrid(broasts);
            }
            else if (check.Equals("Drinks"))
            {
                IOManager.ReadData("Drinks.txt", drinks);
                AddtoGrid(drinks);
            }
            else if(check.Equals("Others"))
            {
                IOManager.ReadData("Others.txt", others);
                AddtoGrid(others);
            }

        }
        


        private void AddtoGrid(List<Burgers> burgers)
        {
            dataTable.Rows.Clear();
            foreach (Burgers items in burgers)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<DesiBurgers> desiBurgers)
        {
            dataTable.Rows.Clear();
            foreach (DesiBurgers items in desiBurgers)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<Broast> broasts)
        {
            dataTable.Rows.Clear();
            foreach (Broast items in broasts)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<Drinks> drinks)
        {
            dataTable.Rows.Clear();
            foreach (Drinks items in drinks)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<Sandwiches> sandwiches)
        {
            dataTable.Rows.Clear();
            foreach(Sandwiches items in sandwiches)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<Fries> fries)
        {
            dataTable.Rows.Clear();
            foreach (Fries items in fries)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<Rolls> rolls)
        {
            dataTable.Rows.Clear();
            foreach (Rolls items in rolls)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<Chatpata> chatpatas)
        {
            dataTable.Rows.Clear();
            foreach (Chatpata items in chatpatas)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<Others> others)
        {
            dataTable.Rows.Clear();
            foreach (Others items in others)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }
        private void AddtoGrid(List<IceCream> iceCreams)
        {
            dataTable.Rows.Clear();
            foreach (IceCream items in iceCreams)
            {
                dataTable.Rows.Add(items.Name, items.Price);
            }
            dataGridView1.DataSource = dataTable;
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            burgers.Clear();
            desiBurgers.Clear();
            broasts.Clear();
            fries.Clear();
            drinks.Clear();
            iceCreams.Clear();
            chatpatas.Clear();
            rolls.Clear();
            sandwiches.Clear();
            others.Clear();
            comboBoxItemtype.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

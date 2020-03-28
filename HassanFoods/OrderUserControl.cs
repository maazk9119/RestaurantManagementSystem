using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using HassanFoods.Report;

namespace HassanFoods
{
    public partial class OrderUserControl : UserControl
    {
        private static OrderUserControl _instance;
        public static OrderUserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new OrderUserControl();
                }
                return _instance;
            }
        }

        //initilization of variables
        int j = 0;
        private int billamount;
        private int dayoffbill;
        private int note;
        private int change;
        private string date = Form1.var;
        private string time = Form1.var1;

        //initilization of lists
        List<Burgers> burgers;
        List<DesiBurgers> desiBurgers;
        List<Broast> broasts;
        List<Drinks> drinks;
        List<Fries> fries;
        List<Rolls> rolls;
        List<Sandwiches> sandwiches;
        List<Chatpata> chatpata;
        List<IceCream> iceCreams;
        List<Others> others;
        List<Order> orders;
        List<DayOffReport> dayOffReports;
        DataTable dataTable;
        
        public OrderUserControl()
        {
            InitializeComponent();
            billamount = 0;
            dayoffbill = 0;
            note = 0;
            change = 0;
            comboBoxitemname.Text = "";
            burgers = new List<Burgers>();
            desiBurgers = new List<DesiBurgers>();
            broasts = new List<Broast>();
            rolls = new List<Rolls>();
            drinks = new List<Drinks>();
            fries = new List<Fries>();
            sandwiches = new List<Sandwiches>();
            chatpata = new List<Chatpata>();
            iceCreams = new List<IceCream>();
            orders = new List<Order>();
            dayOffReports = new List<DayOffReport>();
            others = new List<Others>();
            dataTable = new DataTable();

        }
        private void OrderUserControl_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("FOOD NAME", typeof(string));
            dataTable.Columns.Add("PRICE", typeof(string));
            dataTable.Columns.Add("QUANTITY", typeof(string));
            dataGridView1.DataSource = dataTable;
            
        }

        //Combobox with the name Foodtype
        private void comboBoxItemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string check = comboBoxItemtype.Text;
            comboBoxitemname.Text = "";
            comboBoxitemname.Items.Clear();
            burgers.Clear();
            desiBurgers.Clear();
            broasts.Clear();
            rolls.Clear();
            fries.Clear();
            drinks.Clear();
            sandwiches.Clear();
            chatpata.Clear();
            iceCreams.Clear();
            others.Clear();
            if (check.Equals("Burgers"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Burgers.txt", burgers);
                foreach (Burgers items in burgers)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if (check == "DesiBurgers")
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("DesiBurgers.txt", desiBurgers);
                foreach (DesiBurgers items in desiBurgers)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if (check.Equals("Broast"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Broast.txt", broasts);
                foreach (Broast items in broasts)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if (check.Equals("Rolls"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Rools.txt", rolls);
                foreach (Rolls items in rolls)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if (check.Equals("Fries"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Fries.txt", fries);
                foreach (Fries items in fries)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if (check.Equals("Sandwiches"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Sandwiches.txt", sandwiches);
                foreach (Sandwiches items in sandwiches)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }

            }
            else if (check.Equals("Drinks"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Drinks.txt", drinks);
                foreach (Drinks items in drinks)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if (check.Equals("Icecream"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Icecream.txt", iceCreams);
                foreach (IceCream items in iceCreams)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if (check.Equals("Chatpata"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Chatpata.txt", chatpata);
                foreach (Chatpata items in chatpata)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }
            }
            else if( check.Equals("Others"))
            {
                comboBoxitemname.Items.Clear();
                IOManager.ReadData("Others.txt", others);
                foreach (Others items in others)
                {
                    comboBoxitemname.Items.Add(items.Name);
                }

            }
        }
        
        //All buttons(Methods)
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if(comboBoxitemname.Text==""||comboBoxItemtype.Text==""||textBoxquantity.Text =="")
            {
                MessageBox.Show("Sorry wrong selection");
            }
            if (comboBoxItemtype.Text.Equals("Burgers") && textBoxquantity.Text!="")
            {
                NewOrder(burgers, comboBoxitemname.Text,int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("DesiBurgers")&&textBoxquantity.Text != "")
            {
                NewOrder(desiBurgers, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("Drinks")&& textBoxquantity.Text != "")
            {
                NewOrder(drinks, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("Rolls") && textBoxquantity.Text != "")
            {
                NewOrder(rolls, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("Sandwiches") && textBoxquantity.Text != "")
            {
                NewOrder(sandwiches, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("Broast") && textBoxquantity.Text != "")
            {
                NewOrder(broasts, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("Chatpata") && textBoxquantity.Text != "")
            {
                NewOrder(chatpata, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("Icecream") && textBoxquantity.Text != "")
            {
                NewOrder(iceCreams, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if (comboBoxItemtype.Text.Equals("Fries") && textBoxquantity.Text != "")
            {
                NewOrder(fries, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            else if(comboBoxItemtype.Text.Equals("Others") && textBoxquantity.Text != "")
            {
                NewOrder(others, comboBoxitemname.Text, int.Parse(textBoxquantity.Text));
            }
            
            labelbillamount.Text = billamount.ToString();
        }
        private void BtnCancleItem_Click(object sender, EventArgs e)
        {
            if (comboBoxItemtype.Equals("") && comboBoxitemname.Equals(""))
            {
                MessageBox.Show("something went wrong","Alert");
            }
            else
            {
                //DeleteItemDayoff(comboBoxitemname.Text);
                bool check = DeleteItem(comboBoxitemname.Text,int.Parse(textBoxquantity.Text));
                if (check)
                { }
                else
                    MessageBox.Show("Invalid, can't delete item","Alert");
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            string message = "Do you want to clear this order?";
            string title = "CLEAR ALL";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes && dataTable.Rows != null)
            {
                comboBoxItemtype.Text = "";
                textBoxquantity.Text = "";
                comboBoxitemname.Items.Clear();
                comboBoxitemname.Text = "";
                labelbillamount.Text = "0.0";
                lblreturnamountrs.Text = "0.0";
                textBoxenteramount.Clear();
                dayoffbill = 0;
                billamount = 0;
                orders.Clear();
                burgers.Clear();
                desiBurgers.Clear();
                broasts.Clear();
                rolls.Clear();
                fries.Clear();
                drinks.Clear();
                sandwiches.Clear();
                chatpata.Clear();
                iceCreams.Clear();
                dataTable.Rows.Clear();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)//print button
        {
            foreach (Order item in orders)
            {
                bool check = CheckDayoffreport(item.Name, item.Quantity);
                if (check)
                { }
                else
                {       
                    dayOffReports.Add(new DayOffReport(item.Name, item.Price, item.Quantity));
                }
            }
            
            Recepit recepit = new Recepit();
            j++;
            recepit.Print(orders, labelbillamount.Text, date,time,j,note,change);
            note = 0;
            change = 0;
            recepit.Show();
        }
        private void BtnDayOff_Click(object sender, EventArgs e)
        {
            string message = "Are you sure its a day off? ";
            string heaser = "DAY OFF";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, heaser, buttons);
            if (result.Equals(DialogResult.Yes))
            {
                dataTable.Rows.Clear();
                foreach (DayOffReport items in dayOffReports)
                {
                    dayoffbill = dayoffbill + (items.Price * items.Quantity);
                    dataTable.Rows.Add(items.Name, items.Price, items.Quantity);
                }
                dataGridView1.DataSource = dataTable;
                labelbillamount.Text = dayoffbill.ToString();

                Recepit recepit = new Recepit();
                recepit.DayOff(dayOffReports, time,labelbillamount.Text);
                recepit.Show();
                dayOffReports.Clear();
            }
        }

        //Order Methods for all items
        private void NewOrder(List<Burgers> burgers, string ProductName,int quantity)
        {
            bool check = CheckOrderlist(ProductName,quantity);
            if (check)
            { }
            else
            {
                foreach (Burgers items2 in burgers)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                    }
                }
            }
        }
        private void NewOrder(List<DesiBurgers> desiBurgers, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName,quantity);
            if (check)
            {}
            else
            {
                foreach (DesiBurgers items2 in desiBurgers)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();     
                    }
                }
            }

        }
        private void NewOrder(List<Broast> broasts, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            { }
            else
            {
                foreach (Broast items2 in broasts)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                        
                    }
                }
            }
        }
        private void NewOrder(List<Rolls> rolls, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            {}
            else
            {
                foreach (Rolls items2 in rolls)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                        
                    }
                }
            }

        }
        private void NewOrder(List<Sandwiches> sandwiches, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            {  }
            else
            {
                foreach (Sandwiches items2 in sandwiches)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                    }
                }
            }
        }
        private void NewOrder(List<Drinks> drinks, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            { }
            else
            {
                foreach (Drinks items2 in drinks)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                        
                    }
                }
            }

        }
        private void NewOrder(List<IceCream> iceCreams, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            { }
            else
            {
                foreach (IceCream items2 in iceCreams)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                    }
                }
            }

        }
        private void NewOrder(List<Chatpata> chatpatas, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            {}
            else
            {
                foreach (Chatpata items2 in chatpata)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                        
                    }
                }
            }
        }
        private void NewOrder(List<Fries> fries, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            {}
            else
            {
                foreach (Fries items2 in fries)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                       
                    }
                }
            }
        }
        private void NewOrder(List<Others> others, string ProductName, int quantity)
        {
            bool check = CheckOrderlist(ProductName, quantity);
            if (check)
            { }
            else
            {
                foreach (Others items2 in others)
                {
                    if (items2.Name == ProductName)
                    {
                        orders.Add(new Order(items2.Name, items2.Price, items2.Quantity = quantity));
                        billamount = billamount + (items2.Quantity * items2.Price);
                        Adddatatogrid();
                    }
                }
            }
        }


        /// <summary>
        /// Methods used for different purpose & for code reuseibilty
        /// 1: check quantity and increse by one
        /// 2: check quantity and increse by one
        /// 3: Delete item quantity decrease by one
        /// 4: Show all order items its price and quantity at datagrid
        /// 5:Calculate return amount
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        private bool CheckOrderlist(string ProductName, int quantity)
        {
            foreach (Order items in orders)
            {
                if (items.Name == ProductName)
                {
                    billamount = billamount + (items.Price * quantity);
                    items.Quantity += quantity;
                    Adddatatogrid();
                    return true;
                }
            }
            return false;
        }
        private bool CheckDayoffreport(string ProductName,int quanitiy)
        {
            foreach (DayOffReport items in dayOffReports)
            {
                if (items.Name == ProductName)
                {
                    items.Quantity += quanitiy;
                    return true;
                }
            }
            return false;
        }
        private bool DeleteItem(string ProductName,int quantity)
        {
            foreach (Order items in orders)
            {
                if (items.Name == ProductName && items.Quantity != 0 && items.Quantity >=quantity)
                {
                    billamount = billamount - ( items.Price * quantity);
                    items.Quantity = items.Quantity- quantity;
                    labelbillamount.Text = billamount.ToString();
                    Adddatatogrid();
                    return true;
                }
            }

            return false;
        }
        private void Adddatatogrid()
        {
            dataTable.Rows.Clear();
            if (orders.Count != 0)
            {
                foreach (Order items in orders)
                {
                    dataTable.Rows.Add(items.Name, items.Price, items.Quantity);
                    
                }
                
                dataGridView1.DataSource = dataTable;
            }
        }
        private void CalculateRemainingBlanace(int Note)
        {
            Colourchange();
            note = Note;
            change = note - billamount;
            lblreturnamountrs.Text = change.ToString();        
        }
        private void Colourchange()
        {
            if(billamount > int.Parse(textBoxenteramount.Text))
            {
                lblReturnAmount.Text = "CHANGE";
                lblreturnamountrs.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblReturnAmount.Text = "RETURN AMOUNT";
                lblreturnamountrs.ForeColor = System.Drawing.Color.Blue;
            }

        }

        //extra methods
        private void textBoxenteramount_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void lblminusrs_Click(object sender, EventArgs e)
        {
            if (textBoxenteramount.Text == "")
            {
                MessageBox.Show("First enter amount", "ALERT");
            }
            else
            {
                int n = int.Parse(textBoxenteramount.Text);
                note = int.Parse(textBoxenteramount.Text);
                CalculateRemainingBlanace(n);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

namespace HassanFoods
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelusercontrols = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnViewItems = new System.Windows.Forms.Button();
            this.logout_label = new System.Windows.Forms.Label();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.summary_label = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.order_label = new System.Windows.Forms.Label();
            this.home_label = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelusercontrols
            // 
            this.panelusercontrols.Location = new System.Drawing.Point(163, 75);
            this.panelusercontrols.Name = "panelusercontrols";
            this.panelusercontrols.Size = new System.Drawing.Size(1207, 637);
            this.panelusercontrols.TabIndex = 1;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.BackColor = System.Drawing.Color.White;
            this.LblHeader.Font = new System.Drawing.Font("Bernard MT Condensed", 48F);
            this.LblHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.LblHeader.Location = new System.Drawing.Point(536, -1);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(378, 76);
            this.LblHeader.TabIndex = 18;
            this.LblHeader.Text = "HASSAN FOODS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnViewItems);
            this.panel1.Controls.Add(this.logout_label);
            this.panel1.Controls.Add(this.BtnLogOut);
            this.panel1.Controls.Add(this.summary_label);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnAddItem);
            this.panel1.Controls.Add(this.order_label);
            this.panel1.Controls.Add(this.home_label);
            this.panel1.Controls.Add(this.BtnOrder);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 717);
            this.panel1.TabIndex = 19;
            // 
            // BtnViewItems
            // 
            this.BtnViewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewItems.Font = new System.Drawing.Font("Impact", 20.25F);
            this.BtnViewItems.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnViewItems.Location = new System.Drawing.Point(3, 363);
            this.BtnViewItems.Name = "BtnViewItems";
            this.BtnViewItems.Size = new System.Drawing.Size(154, 79);
            this.BtnViewItems.TabIndex = 23;
            this.BtnViewItems.Text = "VIEW ITEMS";
            this.BtnViewItems.UseVisualStyleBackColor = true;
            this.BtnViewItems.Click += new System.EventHandler(this.BtnViewItems_Click);
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.ForeColor = System.Drawing.SystemColors.Control;
            this.logout_label.Location = new System.Drawing.Point(39, 587);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(81, 13);
            this.logout_label.TabIndex = 32;
            this.logout_label.Text = "See you soon :)";
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Impact", 20.25F);
            this.BtnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLogOut.Location = new System.Drawing.Point(3, 530);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(154, 79);
            this.BtnLogOut.TabIndex = 24;
            this.BtnLogOut.Text = "LOG OUT";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // summary_label
            // 
            this.summary_label.AutoSize = true;
            this.summary_label.ForeColor = System.Drawing.SystemColors.Control;
            this.summary_label.Location = new System.Drawing.Point(30, 666);
            this.summary_label.Name = "summary_label";
            this.summary_label.Size = new System.Drawing.Size(103, 13);
            this.summary_label.TabIndex = 31;
            this.summary_label.Text = "Summary of the day!";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(3, 612);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 79);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HassanFoods.Properties.Resources.cooki;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("Impact", 20.25F);
            this.BtnAddItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAddItem.Location = new System.Drawing.Point(3, 445);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(154, 79);
            this.BtnAddItem.TabIndex = 30;
            this.BtnAddItem.Text = "UPDATES";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.ForeColor = System.Drawing.SystemColors.Control;
            this.order_label.Location = new System.Drawing.Point(48, 337);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(63, 13);
            this.order_label.TabIndex = 25;
            this.order_label.Text = "Place Order";
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.ForeColor = System.Drawing.SystemColors.Control;
            this.home_label.Location = new System.Drawing.Point(48, 254);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(55, 13);
            this.home_label.TabIndex = 1;
            this.home_label.Text = "Our Home";
            // 
            // BtnOrder
            // 
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Impact", 20.25F);
            this.BtnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOrder.Location = new System.Drawing.Point(3, 281);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(154, 79);
            this.BtnOrder.TabIndex = 22;
            this.BtnOrder.Text = "ORDER";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHome.Location = new System.Drawing.Point(3, 198);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(154, 79);
            this.BtnHome.TabIndex = 21;
            this.BtnHome.Text = "HOME";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1191, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(1188, 25);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(0, 13);
            this.LblTime.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 712);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.panelusercontrols);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelusercontrols;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.Label home_label;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnViewItems;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label summary_label;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblTime;
    }
}


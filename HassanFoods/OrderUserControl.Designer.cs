namespace HassanFoods
{
    partial class OrderUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelfooterline = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblFoodName = new System.Windows.Forms.Label();
            this.LblFoodtype = new System.Windows.Forms.Label();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.BtnCancleItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxorder = new System.Windows.Forms.PictureBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.Lbltotalamount = new System.Windows.Forms.Label();
            this.labelbillamount = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.textBoxenteramount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblreturnamountrs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxItemtype = new System.Windows.Forms.ComboBox();
            this.comboBoxitemname = new System.Windows.Forms.ComboBox();
            this.BtnDayOff = new System.Windows.Forms.Button();
            this.lblminusrs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxorder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelfooterline
            // 
            this.panelfooterline.BackColor = System.Drawing.Color.Orange;
            this.panelfooterline.Location = new System.Drawing.Point(0, 574);
            this.panelfooterline.Name = "panelfooterline";
            this.panelfooterline.Size = new System.Drawing.Size(1196, 5);
            this.panelfooterline.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(487, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "ORDER";
            // 
            // LblFoodName
            // 
            this.LblFoodName.AutoSize = true;
            this.LblFoodName.BackColor = System.Drawing.Color.White;
            this.LblFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoodName.Location = new System.Drawing.Point(11, 147);
            this.LblFoodName.Name = "LblFoodName";
            this.LblFoodName.Size = new System.Drawing.Size(145, 25);
            this.LblFoodName.TabIndex = 9;
            this.LblFoodName.Text = "FOOD NAME:";
            // 
            // LblFoodtype
            // 
            this.LblFoodtype.AutoSize = true;
            this.LblFoodtype.BackColor = System.Drawing.Color.White;
            this.LblFoodtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoodtype.Location = new System.Drawing.Point(11, 60);
            this.LblFoodtype.Name = "LblFoodtype";
            this.LblFoodtype.Size = new System.Drawing.Size(140, 25);
            this.LblFoodtype.TabIndex = 10;
            this.LblFoodtype.Text = "FOOD TYPE:";
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.Location = new System.Drawing.Point(16, 340);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(123, 55);
            this.BtnAddItem.TabIndex = 13;
            this.BtnAddItem.Text = "ADD ITEM ";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // BtnCancleItem
            // 
            this.BtnCancleItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancleItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancleItem.Location = new System.Drawing.Point(195, 340);
            this.BtnCancleItem.Name = "BtnCancleItem";
            this.BtnCancleItem.Size = new System.Drawing.Size(127, 55);
            this.BtnCancleItem.TabIndex = 14;
            this.BtnCancleItem.Text = "CANCEL ITEM";
            this.BtnCancleItem.UseVisualStyleBackColor = true;
            this.BtnCancleItem.Click += new System.EventHandler(this.BtnCancleItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(328, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(364, 335);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBoxorder
            // 
            this.pictureBoxorder.Image = global::HassanFoods.Properties.Resources._90596a1ccdd2883;
            this.pictureBoxorder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxorder.Name = "pictureBoxorder";
            this.pictureBoxorder.Size = new System.Drawing.Size(1207, 576);
            this.pictureBoxorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxorder.TabIndex = 0;
            this.pictureBoxorder.TabStop = false;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(582, 401);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(110, 37);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Lbltotalamount
            // 
            this.Lbltotalamount.AutoSize = true;
            this.Lbltotalamount.BackColor = System.Drawing.Color.White;
            this.Lbltotalamount.Location = new System.Drawing.Point(325, 414);
            this.Lbltotalamount.Name = "Lbltotalamount";
            this.Lbltotalamount.Size = new System.Drawing.Size(92, 13);
            this.Lbltotalamount.TabIndex = 17;
            this.Lbltotalamount.Text = "TOTAL AMOUNT";
            // 
            // labelbillamount
            // 
            this.labelbillamount.AutoSize = true;
            this.labelbillamount.BackColor = System.Drawing.Color.White;
            this.labelbillamount.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelbillamount.Location = new System.Drawing.Point(494, 414);
            this.labelbillamount.Name = "labelbillamount";
            this.labelbillamount.Size = new System.Drawing.Size(34, 13);
            this.labelbillamount.TabIndex = 18;
            this.labelbillamount.Text = "0.0    ";
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.BackColor = System.Drawing.Color.White;
            this.lblRS.ForeColor = System.Drawing.Color.Black;
            this.lblRS.Location = new System.Drawing.Point(534, 414);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(22, 13);
            this.lblRS.TabIndex = 19;
            this.lblRS.Text = "RS";
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.BackColor = System.Drawing.Color.White;
            this.lblEnterAmount.Location = new System.Drawing.Point(325, 436);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(94, 13);
            this.lblEnterAmount.TabIndex = 25;
            this.lblEnterAmount.Text = "ENTER AMOUNT";
            // 
            // textBoxenteramount
            // 
            this.textBoxenteramount.Location = new System.Drawing.Point(444, 433);
            this.textBoxenteramount.Name = "textBoxenteramount";
            this.textBoxenteramount.Size = new System.Drawing.Size(69, 20);
            this.textBoxenteramount.TabIndex = 29;
            this.textBoxenteramount.TextChanged += new System.EventHandler(this.textBoxenteramount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(534, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "RS";
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.BackColor = System.Drawing.Color.White;
            this.lblReturnAmount.Location = new System.Drawing.Point(325, 460);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(103, 13);
            this.lblReturnAmount.TabIndex = 31;
            this.lblReturnAmount.Text = "RETURN AMOUNT";
            // 
            // lblreturnamountrs
            // 
            this.lblreturnamountrs.AutoSize = true;
            this.lblreturnamountrs.BackColor = System.Drawing.Color.White;
            this.lblreturnamountrs.ForeColor = System.Drawing.Color.Blue;
            this.lblreturnamountrs.Location = new System.Drawing.Point(494, 460);
            this.lblreturnamountrs.Name = "lblreturnamountrs";
            this.lblreturnamountrs.Size = new System.Drawing.Size(34, 13);
            this.lblreturnamountrs.TabIndex = 32;
            this.lblreturnamountrs.Text = "0.0    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(534, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "RS";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 34;
            this.button1.Text = "PRINT ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxItemtype
            // 
            this.comboBoxItemtype.FormattingEnabled = true;
            this.comboBoxItemtype.Items.AddRange(new object[] {
            "Burgers",
            "DesiBurgers",
            "Broast",
            "Sandwiches",
            "Rolls",
            "Fries",
            "Chatpata",
            "Icecream",
            "Drinks",
            "Others"});
            this.comboBoxItemtype.Location = new System.Drawing.Point(154, 60);
            this.comboBoxItemtype.Name = "comboBoxItemtype";
            this.comboBoxItemtype.Size = new System.Drawing.Size(168, 21);
            this.comboBoxItemtype.TabIndex = 35;
            this.comboBoxItemtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemtype_SelectedIndexChanged);
            // 
            // comboBoxitemname
            // 
            this.comboBoxitemname.FormattingEnabled = true;
            this.comboBoxitemname.Location = new System.Drawing.Point(154, 147);
            this.comboBoxitemname.Name = "comboBoxitemname";
            this.comboBoxitemname.Size = new System.Drawing.Size(168, 21);
            this.comboBoxitemname.TabIndex = 36;
            // 
            // BtnDayOff
            // 
            this.BtnDayOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDayOff.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDayOff.Location = new System.Drawing.Point(1122, 0);
            this.BtnDayOff.Name = "BtnDayOff";
            this.BtnDayOff.Size = new System.Drawing.Size(85, 55);
            this.BtnDayOff.TabIndex = 38;
            this.BtnDayOff.Text = "DAY OFF";
            this.BtnDayOff.UseVisualStyleBackColor = true;
            this.BtnDayOff.Click += new System.EventHandler(this.BtnDayOff_Click);
            // 
            // lblminusrs
            // 
            this.lblminusrs.AutoSize = true;
            this.lblminusrs.BackColor = System.Drawing.Color.Gainsboro;
            this.lblminusrs.ForeColor = System.Drawing.Color.Black;
            this.lblminusrs.Location = new System.Drawing.Point(515, 436);
            this.lblminusrs.Name = "lblminusrs";
            this.lblminusrs.Size = new System.Drawing.Size(13, 13);
            this.lblminusrs.TabIndex = 39;
            this.lblminusrs.Text = "--";
            this.lblminusrs.Click += new System.EventHandler(this.lblminusrs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(534, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "RS";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.BackColor = System.Drawing.Color.White;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(11, 219);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(118, 25);
            this.LblQuantity.TabIndex = 40;
            this.LblQuantity.Text = "QUANTITY";
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.Location = new System.Drawing.Point(154, 224);
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.Size = new System.Drawing.Size(168, 20);
            this.textBoxquantity.TabIndex = 41;
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxquantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.lblminusrs);
            this.Controls.Add(this.BtnDayOff);
            this.Controls.Add(this.comboBoxitemname);
            this.Controls.Add(this.comboBoxItemtype);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblreturnamountrs);
            this.Controls.Add(this.lblReturnAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxenteramount);
            this.Controls.Add(this.lblEnterAmount);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.labelbillamount);
            this.Controls.Add(this.Lbltotalamount);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCancleItem);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.LblFoodtype);
            this.Controls.Add(this.LblFoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelfooterline);
            this.Controls.Add(this.pictureBoxorder);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(1207, 648);
            this.Load += new System.EventHandler(this.OrderUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxorder;
        private System.Windows.Forms.Panel panelfooterline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFoodName;
        private System.Windows.Forms.Label LblFoodtype;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Button BtnCancleItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label Lbltotalamount;
        private System.Windows.Forms.Label labelbillamount;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblEnterAmount;
        private System.Windows.Forms.TextBox textBoxenteramount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.Label lblreturnamountrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxItemtype;
        private System.Windows.Forms.ComboBox comboBoxitemname;
        private System.Windows.Forms.Button BtnDayOff;
        private System.Windows.Forms.Label lblminusrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox textBoxquantity;
    }
}

namespace HassanFoods
{
    partial class AddItemUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblFoodName = new System.Windows.Forms.Label();
            this.LblFoodtype = new System.Windows.Forms.Label();
            this.comboBoxItemtype = new System.Windows.Forms.ComboBox();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.BtnAddItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(487, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "ADD ITEMS";
            // 
            // LblFoodName
            // 
            this.LblFoodName.AutoSize = true;
            this.LblFoodName.BackColor = System.Drawing.Color.White;
            this.LblFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoodName.Location = new System.Drawing.Point(310, 189);
            this.LblFoodName.Name = "LblFoodName";
            this.LblFoodName.Size = new System.Drawing.Size(145, 25);
            this.LblFoodName.TabIndex = 10;
            this.LblFoodName.Text = "FOOD NAME:";
            // 
            // LblFoodtype
            // 
            this.LblFoodtype.AutoSize = true;
            this.LblFoodtype.BackColor = System.Drawing.Color.White;
            this.LblFoodtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoodtype.Location = new System.Drawing.Point(310, 111);
            this.LblFoodtype.Name = "LblFoodtype";
            this.LblFoodtype.Size = new System.Drawing.Size(140, 25);
            this.LblFoodtype.TabIndex = 11;
            this.LblFoodtype.Text = "FOOD TYPE:";
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
            this.comboBoxItemtype.Location = new System.Drawing.Point(480, 111);
            this.comboBoxItemtype.Name = "comboBoxItemtype";
            this.comboBoxItemtype.Size = new System.Drawing.Size(257, 21);
            this.comboBoxItemtype.TabIndex = 36;
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(480, 189);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(257, 20);
            this.textBoxFoodName.TabIndex = 37;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.White;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(310, 265);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(75, 25);
            this.lblprice.TabIndex = 41;
            this.lblprice.Text = "PRICE";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(480, 265);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(257, 20);
            this.textBoxPrice.TabIndex = 42;
            // 
            // BtnAddItems
            // 
            this.BtnAddItems.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItems.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddItems.Location = new System.Drawing.Point(480, 402);
            this.BtnAddItems.Name = "BtnAddItems";
            this.BtnAddItems.Size = new System.Drawing.Size(123, 55);
            this.BtnAddItems.TabIndex = 43;
            this.BtnAddItems.Text = "ADD ITEMS";
            this.BtnAddItems.UseVisualStyleBackColor = false;
            this.BtnAddItems.Click += new System.EventHandler(this.BtnAddItems_Click);
            // 
            // AddItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAddItems);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.comboBoxItemtype);
            this.Controls.Add(this.LblFoodtype);
            this.Controls.Add(this.LblFoodName);
            this.Controls.Add(this.label1);
            this.Name = "AddItemUserControl";
            this.Size = new System.Drawing.Size(1207, 637);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFoodName;
        private System.Windows.Forms.Label LblFoodtype;
        private System.Windows.Forms.ComboBox comboBoxItemtype;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button BtnAddItems;
    }
}

namespace HassanFoods
{
    partial class ViewItemsUserControl
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
            this.lblViewitemsbottom = new System.Windows.Forms.Label();
            this.comboBoxItemtype = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewitemsbottom
            // 
            this.lblViewitemsbottom.AutoSize = true;
            this.lblViewitemsbottom.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewitemsbottom.ForeColor = System.Drawing.Color.Maroon;
            this.lblViewitemsbottom.Location = new System.Drawing.Point(487, 580);
            this.lblViewitemsbottom.Name = "lblViewitemsbottom";
            this.lblViewitemsbottom.Size = new System.Drawing.Size(231, 57);
            this.lblViewitemsbottom.TabIndex = 10;
            this.lblViewitemsbottom.Text = "VIEW ITEMS";
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
            this.comboBoxItemtype.Location = new System.Drawing.Point(380, 83);
            this.comboBoxItemtype.Name = "comboBoxItemtype";
            this.comboBoxItemtype.Size = new System.Drawing.Size(347, 21);
            this.comboBoxItemtype.TabIndex = 36;
            this.comboBoxItemtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemtype_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 440);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRefresh.Location = new System.Drawing.Point(748, 126);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(124, 51);
            this.BtnRefresh.TabIndex = 41;
            this.BtnRefresh.Text = "REFRESH";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ViewItemsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxItemtype);
            this.Controls.Add(this.lblViewitemsbottom);
            this.Name = "ViewItemsUserControl";
            this.Size = new System.Drawing.Size(1207, 637);
            this.Load += new System.EventHandler(this.ViewItemsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewitemsbottom;
        private System.Windows.Forms.ComboBox comboBoxItemtype;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnRefresh;
    }
}

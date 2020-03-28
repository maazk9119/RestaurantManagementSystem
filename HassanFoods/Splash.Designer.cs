namespace HassanFoods
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.labelfoods = new System.Windows.Forms.Label();
            this.panelBrownline = new System.Windows.Forms.Panel();
            this.panelyellowline = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelhassan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelfoods
            // 
            this.labelfoods.AutoSize = true;
            this.labelfoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfoods.ForeColor = System.Drawing.Color.Black;
            this.labelfoods.Location = new System.Drawing.Point(136, 121);
            this.labelfoods.Name = "labelfoods";
            this.labelfoods.Size = new System.Drawing.Size(86, 25);
            this.labelfoods.TabIndex = 4;
            this.labelfoods.Text = "FOODS";
            // 
            // panelBrownline
            // 
            this.panelBrownline.BackColor = System.Drawing.Color.Brown;
            this.panelBrownline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBrownline.Location = new System.Drawing.Point(0, 179);
            this.panelBrownline.Name = "panelBrownline";
            this.panelBrownline.Size = new System.Drawing.Size(393, 10);
            this.panelBrownline.TabIndex = 5;
            // 
            // panelyellowline
            // 
            this.panelyellowline.BackColor = System.Drawing.Color.SandyBrown;
            this.panelyellowline.Location = new System.Drawing.Point(0, 179);
            this.panelyellowline.Name = "panelyellowline";
            this.panelyellowline.Size = new System.Drawing.Size(23, 10);
            this.panelyellowline.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HassanFoods.Properties.Resources.Splashpic;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelhassan
            // 
            this.labelhassan.AutoSize = true;
            this.labelhassan.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhassan.ForeColor = System.Drawing.Color.Brown;
            this.labelhassan.Location = new System.Drawing.Point(110, 82);
            this.labelhassan.Name = "labelhassan";
            this.labelhassan.Size = new System.Drawing.Size(153, 39);
            this.labelhassan.TabIndex = 8;
            this.labelhassan.Text = "HASSAN ";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 189);
            this.Controls.Add(this.labelhassan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelyellowline);
            this.Controls.Add(this.panelBrownline);
            this.Controls.Add(this.labelfoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelfoods;
        private System.Windows.Forms.Panel panelBrownline;
        private System.Windows.Forms.Panel panelyellowline;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelhassan;
    }
}
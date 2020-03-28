namespace HassanFoods
{
    partial class HomeUserControl
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
            this.pictureBoxhome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhome)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxhome
            // 
            this.pictureBoxhome.Image = global::HassanFoods.Properties.Resources.b03c49_e981d52a390840c087d15f5a152665e3_mv2;
            this.pictureBoxhome.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxhome.Name = "pictureBoxhome";
            this.pictureBoxhome.Size = new System.Drawing.Size(1207, 648);
            this.pictureBoxhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxhome.TabIndex = 0;
            this.pictureBoxhome.TabStop = false;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxhome);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1196, 637);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxhome;
    }
}

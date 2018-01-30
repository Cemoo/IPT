namespace IP_BusinessTracking
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
            this.picSpIp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSpIp)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpIp
            // 
            this.picSpIp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSpIp.Image = global::IP_BusinessTracking.Properties.Resources.IP_new;
            this.picSpIp.Location = new System.Drawing.Point(90, 62);
            this.picSpIp.Name = "picSpIp";
            this.picSpIp.Size = new System.Drawing.Size(568, 278);
            this.picSpIp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpIp.TabIndex = 0;
            this.picSpIp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(182, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Telecom İş Takip Sistemi V 1.0.0";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Interval = 1000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSpIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.Shown += new System.EventHandler(this.Splash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picSpIp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSplash;
    }
}
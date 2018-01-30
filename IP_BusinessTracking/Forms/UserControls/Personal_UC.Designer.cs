namespace IP_BusinessTracking
{
    partial class Personal
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
            this.picPers = new System.Windows.Forms.PictureBox();
            this.lblPersName = new System.Windows.Forms.Label();
            this.picStat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).BeginInit();
            this.SuspendLayout();
            // 
            // picPers
            // 
            this.picPers.Location = new System.Drawing.Point(16, 6);
            this.picPers.Name = "picPers";
            this.picPers.Size = new System.Drawing.Size(55, 51);
            this.picPers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPers.TabIndex = 0;
            this.picPers.TabStop = false;
            // 
            // lblPersName
            // 
            this.lblPersName.AutoSize = true;
            this.lblPersName.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersName.Location = new System.Drawing.Point(94, 18);
            this.lblPersName.Name = "lblPersName";
            this.lblPersName.Size = new System.Drawing.Size(114, 28);
            this.lblPersName.TabIndex = 1;
            this.lblPersName.Text = "label1";
            // 
            // picStat
            // 
            this.picStat.Location = new System.Drawing.Point(457, 12);
            this.picStat.Name = "picStat";
            this.picStat.Size = new System.Drawing.Size(41, 36);
            this.picStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStat.TabIndex = 2;
            this.picStat.TabStop = false;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picStat);
            this.Controls.Add(this.picPers);
            this.Controls.Add(this.lblPersName);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(532, 61);
            this.Load += new System.EventHandler(this.Personal_Load);
            this.Click += new System.EventHandler(this.Personal_Click);
            
            ((System.ComponentModel.ISupportInitialize)(this.picPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPersName;
        public System.Windows.Forms.PictureBox picPers;
        public System.Windows.Forms.PictureBox picStat;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_BusinessTracking
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            PersonalInfo p = new PersonalInfo();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picPers.Width - 3, picPers.Height - 3);
            Region rg = new Region(gp);
            picPers.Region = rg;
            Image im = p.ImageURL;
            Image im2 = p.StatusImage;
    
        }
 
        class PersonalInfo {
            public string Name { get; set; }
            public Image ImageURL { get; set; }
            public Image StatusImage { get; set; }
    
        }
      
        void ChangeBackColor()
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.AliceBlue;               
            }
            else
                this.BackColor = Color.White;
        }

        private Personal persContLast = null;
        private void Personal_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            MainForm main =(MainForm) Application.OpenForms["MainForm"];
            if (this.BackColor == Color.Purple)
            {
                var a = this.Tag;
                foreach (Personal item in main.flowLayoutPanel1.Controls)
                {
                    if (item.Tag!=a)
                    {
                        item.BackColor = Color.White;  
                    }
                }             
            }
            else
                this.BackColor = Color.White;
        }

       

        

        

      

    }
}

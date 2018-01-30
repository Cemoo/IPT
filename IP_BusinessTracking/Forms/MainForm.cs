using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_BusinessTracking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static IPTrackingDataContext _ip = new IPTrackingDataContext();
        Status stat = null;
        int c = 1;

        public FlowLayoutPanel flow
        {
            get { return this.flowLayoutPanel1; }
 
            set { this.flow = flowLayoutPanel1;}
        }
        private void Form1_Load(object sender, EventArgs e)
        {        
            this.Location = new Point(Screen.FromPoint(this.Location).WorkingArea.Right - this.Width); 
            HelpMe.FillPersonalList(flowLayoutPanel1);
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            c = 1;        
            if (Application.OpenForms["Status"] == null)
            {
                stat = new Status(); stat.Show();
                stat.Location = new Point((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27);
            }
            else
            {               
                Status stat = new Status(); stat.Show(); 
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "Status")
                    {
                        c++;
                    }                   
                }
                stat.Location = new Point(((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27),
                                       (Screen.FromPoint(this.Location).WorkingArea.Bottom) - (this.Width + (Application.OpenForms["Status"].Size.Height-50*(c+1))));   
            }               
        }

        private void picCherry_Click(object sender, EventArgs e)
        {
         
            picCherry.BackColor = Color.Purple;
            picIPT.BackColor = Color.White;
            picMionix.BackColor = Color.White;
            picNZXT.BackColor = Color.White;
                  
        }

        private void picIPT_Click(object sender, EventArgs e)
        {
            picIPT.BackColor = Color.Purple;
            picMionix.BackColor = Color.White;
            picCherry.BackColor = Color.White;
            picNZXT.BackColor = Color.White;
        }

        private void picMionix_Click(object sender, EventArgs e)
        {
            picMionix.BackColor = Color.Purple;
            picIPT.BackColor = Color.White;
            picCherry.BackColor = Color.White;
            picNZXT.BackColor = Color.White;
        }

        private void picIPT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start("www.iptelecom.com.tr");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonel add = new AddPersonel(); add.Show();
            add.Location = new Point((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) - 70);
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); about.Show();
            about.Location = new Point((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) - 35);

        }

        private void picCherry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start("www.cherryturkiye.com");
        }

        private void picMionix_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start("www.mionix.net");
        }

        private void btmRandevu_Click(object sender, EventArgs e)
        {
            c = 1;
            if (Application.OpenForms["Status"] == null)
            {
                stat = new Status(); stat.Show(); stat.Text = "RANDEVU";
                stat.Location = new Point((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27);
            }
            else
            {
                Status stat = new Status(); stat.Show(); stat.Text = "RANDEVU";
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "Status")
                    {
                        c++;
                    }
                }
                stat.Location = new Point(((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27),
                                       (Screen.FromPoint(this.Location).WorkingArea.Bottom) - (this.Width + (Application.OpenForms["Status"].Size.Height - 50 * (c + 1))));
            }

        }

        private void btnProjeler_Click(object sender, EventArgs e)
        {
            c = 1;
            if (Application.OpenForms["Status"] == null)
            {
                stat = new Status(); stat.Show(); stat.Text = "PROJE";
                stat.Location = new Point((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27);
            }
            else
            {
                Status stat = new Status(); stat.Show(); stat.Text = "PROJE";
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "Status")
                    {
                        c++;
                    }
                }
                stat.Location = new Point(((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27),
                                       (Screen.FromPoint(this.Location).WorkingArea.Bottom) - (this.Width + (Application.OpenForms["Status"].Size.Height - 50 * (c + 1))));
            }
        }

        private void btnMontaj_Click(object sender, EventArgs e)
        {
            c = 1;
            if (Application.OpenForms["Status"] == null)
            {
                stat = new Status(); stat.Show(); stat.Text = "MONTAJ";
                stat.Location = new Point((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27);
            }
            else
            {
                Status stat = new Status(); stat.Show(); stat.Text = "MONTAJ";
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "Status")
                    {
                        c++;
                    }
                }
                stat.Location = new Point(((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 27),
                                       (Screen.FromPoint(this.Location).WorkingArea.Bottom) - (this.Width + (Application.OpenForms["Status"].Size.Height - 50 * (c + 1))));
            }
        }

        private void picNZXT_Click(object sender, EventArgs e)
        {
            picNZXT.BackColor = Color.Purple;
            picMionix.BackColor = Color.White;
            picCherry.BackColor = Color.White;
            picIPT.BackColor = Color.White;
        }

      
         
      
    }
}

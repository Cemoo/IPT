using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_BusinessTracking
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
           // tmrSplash.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {           
           tmrSplash.Stop();
           MainForm main = new MainForm();
           main.Show();
           this.Hide();
        }       

        private void Splash_Shown(object sender, EventArgs e)
        {
            tmrSplash.Start();
        }

    }
}

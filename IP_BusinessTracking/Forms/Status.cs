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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }
        public IPTrackingDataContext ip = new IPTrackingDataContext();
        int c = 1;
        Status stat = null;
        private void Status_Load(object sender, EventArgs e)
        {
            cmbDep.DataSource = GetDbItems.GetDepartments();
            cmbServices.DataSource = GetDbItems.GetMissions();
            cmbPers.DataSource = GetDbItems.GetPersonel();
        }

        private void cmbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (from a in ip.Departments where a.AuthName == cmbDep.SelectedItem select a.AuthID).FirstOrDefault();
            var pers = from b in ip.PersonalInformations where b.Departman == id select b;
            if (pers.Count() != 0)
            {
                cmbPers.DataSource = null;
                cmbPers.Items.Clear();
                foreach (var item in pers)
                {
                    cmbPers.Items.Add(item.Name + " " + item.Surname);
                    
                }
                cmbPers.SelectedIndex = 0;
            }
            else
                cmbPers.DataSource = GetDbItems.GetPersonel();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
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
                stat.Location = new Point(((Screen.FromPoint(this.Location).WorkingArea.Right) - (this.Width + Application.OpenForms["MainForm"].Size.Width) + 20),
                                       (Screen.FromPoint(this.Location).WorkingArea.Bottom) - (this.Width + (Application.OpenForms["Status"].Size.Height - 50 * (c + 1))));
            }  
        }
    }
}

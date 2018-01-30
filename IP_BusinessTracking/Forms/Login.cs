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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public IPTrackingDataContext ip = new IPTrackingDataContext();
        public static string name = "";
        public static string surname = "";
        private void btnOK_Click(object sender, EventArgs e)
        {
            var pers = (from a in ip.PersonalInformations where a.Username == txtUser.Text && a.Password == txtPass.Text select a);
            if (pers.Count() != 0)
            {
                Splash sp = new Splash();
                sp.Show(); this.Hide();
                foreach (var item in pers)
            	{
            		 name = item.Name;
                     surname = item.Surname;
            	}
                
            }
            else
            {
                Error er = new Error();
                er.date = DateTime.Now;
                er.LogType = "Login Hatası";
                er.Explanation = "Kullanıcı tarafından giriş hatası yapıldı";
                if (AddLog.Add_Log(er.LogType, er.Explanation, er.date))
                {
                    lblDurum.Text = "Kullanıcı bilgileri yanlış";
                }
                else
                    lblDurum.Text = "Kullanıcı bilgileri yanlış ve log eklenemedi";
            }

        }
    }
}

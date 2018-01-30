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
    public partial class AddPersonel : Form
    {
        public AddPersonel()
        {
            InitializeComponent();
        }
        string fileName = "";
        public IPTrackingDataContext _ip = new IPTrackingDataContext();
        public static Guid PersID;
        private void AddPersonel_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = GetDbItems.GetDepartments();
            cmbDep.DataSource = GetDbItems.GetDepartments();
            cmbUpPers.DataSource = GetDbItems.GetPersonel();
            cmbDelPers.DataSource = GetDbItems.GetPersonel();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = PersonelProcess.AddPersonal(Guid.NewGuid(),
                                                txtAdi.Text,
                                                txtSoyadi.Text,
                                                txtTelefon.Text,
                                                txtTCNo.Text,
                                                txtAdress.Text,
                                                txtMailAdress.Text,
                                                fileName,
                                                (from a in _ip.Departments where a.AuthName == cmbDepartment.SelectedItem select a.AuthID).FirstOrDefault(),
                                                txtUser.Text,
                                                txtPassw.Text,
                                                DateTime.Now,
                                                false,
                                                Convert.ToDateTime("1900-10-01 00:00:00.000")
                                                );
                if (result) { 
                    lblDurum.Text = "Kayıt başarılı";
                    cmbDepartment.DataSource = GetDbItems.GetDepartments();
                    cmbDep.DataSource = GetDbItems.GetDepartments();
                    cmbUpPers.DataSource = GetDbItems.GetPersonel();
                    cmbDelPers.DataSource = GetDbItems.GetPersonel();

                    MainForm main = (MainForm)Application.OpenForms["MainForm"];
                    main.flowLayoutPanel1.Controls.Clear();
                    int index = 0;
                    var personals = from a in _ip.PersonalInformations where a.IsDeleted == false select a;
                    // index = personals.Count();
                    // this.Location = new Point(Screen.FromPoint(this.Location).WorkingArea.Right - this.Width);

                    foreach (var item in personals)
                    {
                        Personal pers = new Personal();
                        pers.Tag = index;
                        pers.lblPersName.Text = item.Name + " " + item.Surname;
                        try
                        {
                            pers.picPers.Image = Image.FromFile(item.P_Image);
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            pers.picPers.Image = HelpMe.ScaleImage(Image.FromFile(item.P_Image), 80, 74);
                        }
                        catch (Exception)
                        {
                        }
                        pers.picStat.Image = Properties.Resources.green;
                        pers.picStat.Image = HelpMe.ScaleImage(Properties.Resources.green, 20, 18);
                        
                        main.flowLayoutPanel1.Controls.Add(pers);
                        //f.Controls.Add(pers);
                        index++;
                    }

                   
                }
            }
            catch (Exception)
            {
                lblDurum.Text = "Kayıt başarısız";
            }
        }

        private void picPersAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileName = open.FileName;
                picPersAdd.Image = Image.FromFile(fileName);

            }
        }

        private void txtTCNo_Leave(object sender, EventArgs e)
        {
            if (txtTCNo.Text.Count()!=11){        
                lblDurum.Text = "Tc numarasını doğru giriniz";
                txtTCNo.BackColor = Color.Red;
            }
            else
                txtTCNo.BackColor = Color.White;           
        }

        private void txtTC_Leave(object sender, EventArgs e)
        {
            if (txtTC.Text.Count() != 11)
            {
                lblDurum.Text = "Tc numarasını doğru giriniz";
                txtTC.BackColor = Color.Red;
            }
            else
                txtTC.BackColor = Color.White; 
        }

        private void cmbUpPers_SelectedIndexChanged(object sender, EventArgs e)
        {

            var pers = (from a in _ip.PersonalInformations where a.Name + " " + a.Surname == cmbUpPers.SelectedItem select a).FirstOrDefault();
            PersID = pers.PID;
            txtAd.Text = pers.Name;
            txtSoyad.Text = pers.Surname;
            try
            {
                picPers.Image = Image.FromFile((from a in _ip.PersonalInformations where a.Name + " " + a.Surname == cmbUpPers.SelectedItem select a.P_Image).FirstOrDefault());
            }
            catch (Exception)
            {
                
                picPers.Image = null;
            }
            txtTel.Text = pers.Tel;
            txtAdres.Text = pers.Adress;
            txtTC.Text = pers.TC;
            txtMail.Text = pers.Mail;
            cmbDep.SelectedItem=  (from d in _ip.Departments where d.AuthID==(from a in _ip.PersonalInformations where a.Name + " " + a.Surname == cmbUpPers.SelectedItem select a.Departman).FirstOrDefault() select d.AuthName).FirstOrDefault();
            txtUserName.Text = pers.Username;
            txtPass.Text = pers.Password;
        }

        private void picPers_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileName = open.FileName;
                picPers.Image = Image.FromFile(fileName);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          // Guid g =  (from a in _ip.Departments where a.AuthName == cmbDep.SelectedItem select a.AuthID).FirstOrDefault();
           bool result= PersonelProcess.UpdatePersonal(PersID, txtAd.Text, txtSoyad.Text, txtTel.Text, txtTC.Text, txtAdres.Text, txtMail.Text, fileName,
                                            (from a in _ip.Departments where a.AuthName == cmbDep.SelectedItem select a.AuthID).FirstOrDefault(), txtUserName.Text,
                                            txtPass.Text,
                                             Convert.ToDateTime((from a in _ip.PersonalInformations where a.PID == PersID select a.AddedTime).FirstOrDefault()),
                                            false,
                                            Convert.ToDateTime((from a in _ip.PersonalInformations where a.PID == PersID select a.DeletedTime).FirstOrDefault()));
           if (result)
           {
               lblDurum.Text = "Güncelleme başarılı";

                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                    main.flowLayoutPanel1.Controls.Clear();
                    int index = 0;
                    var personals = from a in _ip.PersonalInformations where a.IsDeleted == false select a;
                    // index = personals.Count();
                    // this.Location = new Point(Screen.FromPoint(this.Location).WorkingArea.Right - this.Width);

                    foreach (var item in personals)
                    {
                        Personal pers = new Personal();
                        pers.Tag = index;
                        pers.lblPersName.Text = item.Name + " " + item.Surname;
                        try
                        {
                            pers.picPers.Image = Image.FromFile(item.P_Image);
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            pers.picPers.Image = HelpMe.ScaleImage(Image.FromFile(item.P_Image), 80, 74);
                        }
                        catch (Exception)
                        {
                        }
                        pers.picStat.Image = Properties.Resources.green;
                        pers.picStat.Image = HelpMe.ScaleImage(Properties.Resources.green, 20, 18);

                        main.flowLayoutPanel1.Controls.Add(pers);
                        //f.Controls.Add(pers);
                        index++;
                    }
           }
           else
               lblDurum.Text = "Güncelleme başarısız";

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var person = (from a in _ip.PersonalInformations where a.Name + " " + a.Surname == cmbDelPers.SelectedItem select a).FirstOrDefault();
                person.IsDeleted = true;
                person.DeletedTime = DateTime.Now;
                _ip.SubmitChanges();
                lblDurum.Text = "Personel silindi";
                cmbDelPers.DataSource = GetDbItems.GetPersonel();

                    MainForm main = (MainForm)Application.OpenForms["MainForm"];
                    main.flowLayoutPanel1.Controls.Clear();
                    int index = 0;
                    var personals = from a in _ip.PersonalInformations where a.IsDeleted == false select a;
                    // index = personals.Count();
                    // this.Location = new Point(Screen.FromPoint(this.Location).WorkingArea.Right - this.Width);

                    foreach (var item in personals)
                    {
                        Personal pers = new Personal();
                        pers.Tag = index;
                        pers.lblPersName.Text = item.Name + " " + item.Surname;
                        try
                        {
                            pers.picPers.Image = Image.FromFile(item.P_Image);
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            pers.picPers.Image = HelpMe.ScaleImage(Image.FromFile(item.P_Image), 80, 74);
                        }
                        catch (Exception)
                        {
                        }
                        pers.picStat.Image = Properties.Resources.green;
                        pers.picStat.Image = HelpMe.ScaleImage(Properties.Resources.green, 20, 18);

                        main.flowLayoutPanel1.Controls.Add(pers);
                        //f.Controls.Add(pers);
                        index++;
                    }
            }
            catch (Exception)
            {             
                lblDurum.Text = "Persoonel silme başarısız";
            }

        }

   
    }
}

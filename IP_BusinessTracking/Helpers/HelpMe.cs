using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_BusinessTracking
{
    class HelpMe
    {
        public static IPTrackingDataContext _ip = new IPTrackingDataContext();
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            var newImage = new Bitmap(newWidth, newHeight);
            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
        public static void FillPersonalList(FlowLayoutPanel f)
        {
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
               // Application.OpenForms["MainForm"].Controls["flowLayoutPanel1"].Controls.Add(pers);
                f.Controls.Add(pers);
                index++;
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_BusinessTracking
{
    class PersonelProcess
    {
        public static IPTrackingDataContext _ip = new IPTrackingDataContext();
        public static bool AddPersonal(Guid id, string name, string surname, string tel, string tc, string adress, string mail, string imageURL, Guid dep, string username, string pass, DateTime addedTime, bool IsDeleted, DateTime deletedTime)
        {
            try
            {
                var personalwehad = (from a in _ip.PersonalInformations where a.TC == tc select a).FirstOrDefault();
                if (personalwehad == null)
                {
                    PersonalInformation pers = new PersonalInformation();
                    pers.PID = Guid.NewGuid();
                    pers.Name = name;
                    pers.Surname = surname;
                    pers.Tel = tel;
                    pers.TC = tc;
                    pers.Adress = adress;
                    pers.Mail = mail;
                    pers.P_Image = imageURL;
                    pers.Departman = dep;
                    pers.Username = username;
                    pers.Password = pass;
                    pers.AddedTime = addedTime;
                    pers.IsDeleted = IsDeleted;
                    pers.DeletedTime = deletedTime;
                    _ip.PersonalInformations.InsertOnSubmit(pers);
                    _ip.SubmitChanges();
                }
                return true;
            }
            catch (Exception)
            {
                Error error = new Error();
                error.LogType ="Personel Ekleme";
                error.Explanation = "Personel ekleme başarısız ya da personel mecvut.";
                if (AddLog.Add_Log(error.LogType, error.Explanation,DateTime.Now))
                    return false;
                return false;
            }


        }
        public static bool DeletePersonel(string tc){
            try
            {
                var pers = (from a in _ip.PersonalInformations where a.TC == tc select a).FirstOrDefault();
                pers.IsDeleted = true;
                pers.DeletedTime = DateTime.Now;
                _ip.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                Error error = new Error();
                error.LogType = "Personel Silme";
                error.Explanation = "Personel silme başarısız";
                if (AddLog.Add_Log(error.LogType, error.Explanation,DateTime.Now))
                    return false;
                return false;
            }
            
        }
        public static bool UpdatePersonal(Guid persId, string name, string surname, string tel, string tc, string adress, string mail, string imageURL, Guid dep, string username, string pass, DateTime addedTime, bool IsDeleted, DateTime deletedTime)
        {
            try
            {
                var pers = (from a in _ip.PersonalInformations where a.PID == persId select a).FirstOrDefault();
                pers.TC = tc;
                pers.Name = name;
                pers.Surname = surname;
                pers.Tel = tel;
                pers.TC = tc;
                pers.Adress = adress;
                pers.Mail = mail;
                pers.P_Image = imageURL;
                pers.Departman = dep;
                pers.Username = username;
                pers.Password = pass;
                pers.AddedTime = addedTime;
                pers.IsDeleted = IsDeleted;
                pers.DeletedTime = deletedTime;
                _ip.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                
                Error error = new Error();
                error.LogType = "Personel Guncelleme";
                error.Explanation = "Personel guncelleme başarısız";
                error.date = DateTime.Now;
                if (AddLog.Add_Log(error.LogType, error.Explanation,DateTime.Now))
                    return false;
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_BusinessTracking
{
    class PersonalInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tel{ get; set; }
        public string TC { get; set; }
        public string Adress { get; set; }
        public string Mail { get; set; }
        public string Image { get; set; }
        public Guid Department { get; set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime AddedTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedTme { get; set; }
        
        public PersonalInfo(string p_name, string p_surname, string p_tel,string p_TC, string p_Adress, string p_Mail, string p_URL, Guid p_dep, string p_username, string p_pass,DateTime p_add,bool p_IsDel,DateTime p_DelTime)
        {
            this.Name = p_name;
            this.Surname = p_surname;
            this.Tel = p_tel;
            this.TC = p_TC;
            this.Adress = p_Adress;
            this.Mail = p_Mail;
            this.Image = p_URL;
            this.Department = p_dep;
            this.Username = p_username;
            this.Password = p_pass;
            this.AddedTime = p_add;
            this.IsDeleted = p_IsDel;
            this.DeletedTme = p_DelTime;
        }
    }
}

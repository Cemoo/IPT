using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_BusinessTracking
{
    class GetDbItems
    {
        public static IPTrackingDataContext _ip = new IPTrackingDataContext();
        public static List<string> GetDepartments()
        {
            var names = from p in _ip.Departments select p.AuthName;
            List<string> st = new List<string>();
            foreach (var item in names)
            {              
                st.Add(item.ToString());                 
            }
            return st;
        }

        public static List<string> GetPersonel()
        {
            var names = from p in _ip.PersonalInformations where p.IsDeleted == false select p.Name + " " + p.Surname; 
            List<string> st = new List<string>();
            foreach (var item in names)
            {
                
               st.Add(item.ToString()); 
                
            }
            return st;
        }

        public static List<string> GetMissions()
        {
            var names = from p in _ip.Missions select p.MissionName;
            List<string> st = new List<string>();
            foreach (var item in names)
            {

                st.Add(item.ToString());

            }
            return st;
        }

      
    }
}

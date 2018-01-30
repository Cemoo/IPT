using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_BusinessTracking
{
    class AddLog
    {
        public static IPTrackingDataContext _ip = new IPTrackingDataContext();
        public static bool Add_Log(string p_logType, string p_Exp, DateTime logTime)
        {
            
            try
            {
                Log logs = new Log();
                logs.LogID = Guid.NewGuid() ;
                logs.LogType = p_logType;
                logs.Explanation = p_Exp;
                logs.Date = logTime;
                _ip.Logs.InsertOnSubmit(logs);
                _ip.SubmitChanges();
                return true;
            }
            catch (Exception)
            {                
                return false;
            }

        }
    }
}

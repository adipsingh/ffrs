using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Business
{
    public class Common
    {
        public static string GetUserIp
        {
            get
            {
                string visitorsIpAddr = string.Empty;
                if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                {
                    visitorsIpAddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                }
                else if (!string.IsNullOrEmpty(HttpContext.Current.Request.UserHostAddress))
                {
                    visitorsIpAddr = HttpContext.Current.Request.UserHostAddress;
                }
                return visitorsIpAddr;
            }
        }

        public static emailsetting GetEmailSettings(string custid)
        {
            frssdbEntities entities = new frssdbEntities();
            emailsetting settings = entities.emailsettings.FirstOrDefault(s => s.custid == custid);
            if (settings == null) return null;
            return settings;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FRSS.Utility
{
    public class ProjectSession
    {
        public static string UserId
        {
            get
            {
                if (HttpContext.Current.Session["UserID"] != null && HttpContext.Current.Session["UserID"].ToString().Length > 0)
                {
                    return Convert.ToString(HttpContext.Current.Session["UserID"]);
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["UserID"] = value;
            }
        }

        public static string UserName
        {
            get
            {
                if (HttpContext.Current.Session["UserName"] != null && HttpContext.Current.Session["UserName"].ToString().Length > 0)
                {
                    return HttpContext.Current.Session["UserName"].ToString();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["UserName"] = value;
            }
        }

        public static string distcontactno
        {
            get
            {
                if (HttpContext.Current.Session["distcontactno"] != null && HttpContext.Current.Session["distcontactno"].ToString().Length > 0)
                {
                    return HttpContext.Current.Session["distcontactno"].ToString();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["distcontactno"] = value;
            }
        }

        public static string distemailid
        {
            get
            {
                if (HttpContext.Current.Session["distemailid"] != null && HttpContext.Current.Session["distemailid"].ToString().Length > 0)
                {
                    return HttpContext.Current.Session["distemailid"].ToString();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["distemailid"] = value;
            }
        }

        public static string custid
        {
            get
            {
                if (HttpContext.Current.Session["custid"] != null && HttpContext.Current.Session["custid"].ToString().Length > 0)
                {
                    return Convert.ToString(HttpContext.Current.Session["custid"]).ToUpper();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["custid"] = value;
            }
        }

        public static bool addrights
        {
            get
            {
                if (HttpContext.Current.Session["addrights"] != null && HttpContext.Current.Session["addrights"].ToString().Length > 0)
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["addrights"]);
                }
                return false;
            }
            set
            {
                HttpContext.Current.Session["addrights"] = value;
            }
        }

        public static bool editrights
        {
            get
            {
                if (HttpContext.Current.Session["editrights"] != null && HttpContext.Current.Session["editrights"].ToString().Length > 0)
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["editrights"]);
                }
                return false;
            }
            set
            {
                HttpContext.Current.Session["editrights"] = value;
            }
        }

        public static bool deleterights
        {
            get
            {
                if (HttpContext.Current.Session["deleterights"] != null && HttpContext.Current.Session["deleterights"].ToString().Length > 0)
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["deleterights"]);
                }
                return false;
            }
            set
            {
                HttpContext.Current.Session["deleterights"] = value;
            }
        }

        public static bool uploadrights
        {
            get
            {
                if (HttpContext.Current.Session["uploadrights"] != null && HttpContext.Current.Session["uploadrights"].ToString().Length > 0)
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["uploadrights"]);
                }
                return false;
            }
            set
            {
                HttpContext.Current.Session["uploadrights"] = value;
            }
        }

        public static bool downloadrights
        {
            get
            {
                if (HttpContext.Current.Session["downloadrights"] != null && HttpContext.Current.Session["downloadrights"].ToString().Length > 0)
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["downloadrights"]);
                }
                return false;
            }
            set
            {
                HttpContext.Current.Session["downloadrights"] = value;
            }
        }

        public static bool sendmailrights
        {
            get
            {
                if (HttpContext.Current.Session["sendmailrights"] != null && HttpContext.Current.Session["sendmailrights"].ToString().Length > 0)
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["sendmailrights"]);
                }
                return false;
            }
            set
            {
                HttpContext.Current.Session["sendmailrights"] = value;
            }
        }


        public static string serialkey
        {
            get
            {
                if (HttpContext.Current.Session["serialkey"] != null && HttpContext.Current.Session["serialkey"].ToString().Length > 0)
                {
                    return Convert.ToString(HttpContext.Current.Session["serialkey"]).ToUpper();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["serialkey"] = value;
            }
        }

        public static string registerowner
        {
            get
            {
                if (HttpContext.Current.Session["registerowner"] != null && HttpContext.Current.Session["registerowner"].ToString().Length > 0)
                {
                    return Convert.ToString(HttpContext.Current.Session["registerowner"]).ToUpper();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["registerowner"] = value;
            }
        }

        public static string expirydate
        {
            get
            {
                if (HttpContext.Current.Session["expirydate"] != null && HttpContext.Current.Session["expirydate"].ToString().Length > 0)
                {
                    return Convert.ToString(HttpContext.Current.Session["expirydate"]).ToUpper();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["expirydate"] = value;
            }
        }

        public static string nocompactive
        {
            get
            {
                if (HttpContext.Current.Session["nocompactive"] != null && HttpContext.Current.Session["nocompactive"].ToString().Length > 0)
                {
                    return Convert.ToString(HttpContext.Current.Session["nocompactive"]).ToUpper();
                }
                return string.Empty;
            }
            set
            {
                HttpContext.Current.Session["nocompactive"] = value;
            }
        }

    }
}
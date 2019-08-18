using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FRSS.Helpers
{
    /// <summary>
    /// Summary description for UploadHandler
    /// </summary>
    public class UploadHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            try
            {
                string path = "/Upload/";

                string Serverpath = HttpContext.Current.Server.MapPath("~" + path);

                if (!Directory.Exists(Serverpath))
                    Directory.CreateDirectory(Serverpath);

                var postedFile = context.Request.Files[0];
                string file;

                //In case of IE
                if (HttpContext.Current.Request.Browser.Browser.ToUpper() == "IE")
                {
                    string[] files = postedFile.FileName.Split(new char[] { });
                    file = files[files.Length - 1];
                }
                else // In case of other browsers
                {
                    file = postedFile.FileName;
                }
                
                string fileDirectory = Serverpath;
                //if (context.Request.QueryString["fileName"] != null)
                //{
                //    file = context.Request.QueryString["fileName"];
                //    if (File.Exists(fileDirectory + "\\" + file))
                //    {
                //        File.Delete(fileDirectory + "\\" + file);
                //    }
                //}
                
                fileDirectory = Serverpath + file;

                postedFile.SaveAs(fileDirectory);

                context.Response.Write(file);
            }
            catch (Exception exp)
            {
                context.Response.Write("error: " + exp.Message);
            }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        
    }
}
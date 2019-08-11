using System.Text;
using System.Web.Mvc;

namespace FRSS.Helpers
{
    public class ReplyFormat
    {
        public class Reply
        {
            public string status { get; set; }
            public string message { get; set; }
            public string error { get; set; }
            public dynamic data { get; set; }
        }

        public JsonResult Success(string txt, dynamic data = null)
        {
            return PrepareReply(false, txt, data);
        }

        public JsonResult Error(string txt)
        {
            return PrepareReply(true, txt);
        }

        public JsonResult PrepareReply(bool isError, string txt, dynamic data = null)
        {
            var reply = new Reply
            {
                status = isError ? Message.FAIL : Message.SUCCESS,
                message = isError ? "" : txt,
                error = isError ? txt : null,
                data = data,
            };
            return new JsonNetResult(reply, JsonRequestBehavior.AllowGet);
        }
    }

    public class Message
    {
        public const string FAIL = "Fail";
        public const string SUCCESS = "Success";
        public const string UNAUTHORIZED = "You are not authorized.";
        public const string UserNotExist = "User does not exist anymore, please contact admin.";
        public const string UserInActive = "Your profile has been temporary inactive, please contact admin.";
        public const string UserDeleted = "Your profile has been deleted by you or admin, please contact admin.";
        public const string PASSWORD_SUCCESS = "Please check your email";
        public const string BAD_DATA = "Bad or Invalid data";
        public const string PASSWORD_FORGOT = "Forgot Password Request";
        public const string PASSWORD_FORGOT_MESSAGE = "Hello,<br/><br/>We received a request to forgot the password for your Account {0}.<br/>Password : {1}<br/><br/>Please contact us if you have any problems with your login.<br/>Thank you";
    }

    public class JsonNetResult : JsonResult
    {

        private JsonNetResult()
        {
            this.ContentType = "application/json";
        }

        public JsonNetResult(object data, JsonRequestBehavior jsonRequestBehavior)
        {
            this.ContentEncoding = Encoding.UTF8;
            this.ContentType = "application/json";
            this.Data = data;
            this.JsonRequestBehavior = jsonRequestBehavior;
        }
    }
}
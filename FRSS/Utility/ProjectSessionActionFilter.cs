﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FRSS.Utility
{
    public class ProjectSessionActionFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrEmpty(ProjectSession.UserName))
            {
                filterContext.Result = new RedirectToRouteResult(
                 new RouteValueDictionary
                 {
                    { "controller", "Account" },
                    { "action", "Login" }
                 });
            }
        }
    }
}
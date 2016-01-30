﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition(
           "jquery",
            new ScriptResourceDefinition
            {
                 Path = "~/jquery-1.10.2.js",
                 DebugPath = "~/jquery-1.10.2.js",
                 CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js",
                 CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.js",
                 CdnSupportsSecureConnection = true,
                 LoadSuccessExpression = "jQuery"
            });
        }
    }
}
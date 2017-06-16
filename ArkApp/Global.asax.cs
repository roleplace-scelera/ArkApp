using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using QueryMaster;
using System.Security.Cryptography;

namespace ArkApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            // Testing 
            var Game = QueryMaster.Game.ARK_Survival_Evolved;
            string IP = "85.190.157.119";
            
            ushort Port = 27001;


            var Server = QueryMaster.GameServer.ServerQuery.GetServerInstance(Game, IP, Port);
            var ServerInfo = Server.GetInfo();
            Console.Out.Write(ServerInfo.ToString());

        }
    }
}
﻿using Microsoft.Owin;
using Owin;
using WebApplication2.SignalR.Sample;


[assembly: OwinStartup(typeof(Startup))] 
namespace WebApplication2.SignalR.Sample
{
    public static class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application using OWIN startup, visit http://go.microsoft.com/fwlink/?LinkID=316888

             app.MapSignalR();
        }
    }
}
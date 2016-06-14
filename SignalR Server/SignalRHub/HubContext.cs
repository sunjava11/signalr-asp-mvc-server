using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Server.SignalRHub
{
    public static class HubContext
    {
        public static void DownloadContent()
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<TestHub>();
            hub.Clients.All.DownloadContent();
        }
    }
}
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Server.SignalRHub
{
    [HubName("myServerHub")]
    public class TestHub : Hub
    {

    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Owin;
using Microsoft.Owin;

namespace LiveChat.signalr.hubs
{
    public class ChatHub : Hub
    {
       public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name,message);
        }
     
    }
}
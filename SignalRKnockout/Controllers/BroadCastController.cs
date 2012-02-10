using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalR.Hubs;
using SignalRKnockout.Models;

namespace SignalRKnockout.Controllers
{
    public class BroadCastController : Controller
    {

        public ActionResult Index()
        {
            Hub hub = new MessageHub();
            

            return View();
        }

    }
}

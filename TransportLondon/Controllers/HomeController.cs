using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportLondon.Services;

namespace TransportLondon.Controllers
{
    public class HomeController : Controller
    {               
        public ActionResult Index()
        {
            return View();
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportLondon.Services;

namespace TransportLondon.Controllers
{
    public class TransportController : Controller
    {
        TflService _service = new TflService();

        public JsonResult Line(string Mode)
        {
            return Json(_service.GetLine(Mode), JsonRequestBehavior.AllowGet);
        }
    }
}
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

        public JsonResult Lines(string mode)
        {
            switch(mode)
                {
                case "Tube":
                    return Json(_service.GetLineTube(), JsonRequestBehavior.AllowGet);
                //case "Bus":
                //    return Json(_service.GetLineTube(), JsonRequestBehavior.AllowGet);
                //case "DLR":
                //    return Json(_service.GetLineTube(), JsonRequestBehavior.AllowGet); 
                //case "NRail":
                //    return Json(_service.GetLineTube(), JsonRequestBehavior.AllowGet);
                default: return null;
            }
            
        }

        public JsonResult Line(string id)
        {
            
            return Json(_service.GetLine(id), JsonRequestBehavior.AllowGet);
        }
    }
}
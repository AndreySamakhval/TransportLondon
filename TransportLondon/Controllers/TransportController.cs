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
        ITflService _service;

        public TransportController(ITflService Service)
        {
            _service = Service;
        }

        public JsonResult Lines(string mode)
        {
            switch(mode)
                {
                case "Tube":
                    return Json(_service.GetLineTube(), JsonRequestBehavior.AllowGet);
                case "Bus":
                    return Json(_service.GetLineBus(), JsonRequestBehavior.AllowGet);
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

        public string LineInfo(string id)
        {

            return _service.GetLineInfo(id);
        }

        public JsonResult LineStops(string id)
        {

            return Json(_service.GetStops(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Prediction(string id)
        {
            return Json(_service.GetPrediction(id), JsonRequestBehavior.AllowGet);
        }

        public string Route(string id)
        {
            return _service.GetRoutes(id);
        }

        public void test(string id= "490005183E")
        {
            _service.test(id);
        }
        
    }
}
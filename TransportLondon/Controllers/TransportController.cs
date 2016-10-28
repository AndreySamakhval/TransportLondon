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

        public JsonResult Route(string id)
        {
            return Json(_service.GetRoutes(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult SearchStop(string id)
        {
            return Json(_service.SearchStop(id), JsonRequestBehavior.AllowGet);
        }        
    }
}
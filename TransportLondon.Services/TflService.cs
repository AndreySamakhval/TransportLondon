using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities;
using TransportLondon.DAL;
using TransportLondon.Viewmodel;

namespace TransportLondon.Services
{
    public class TflService : ITflService
    {
        ITflProvider _provider;

        public TflService(ITflProvider Provider)
        {
            _provider = Provider;
        }

        public List<LineTubeViewModel> GetLineTube()
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/tube/status");
            if (stringJson == null)
                return null;
            var lines = JsonConvert.DeserializeObject<List<Line>>(stringJson);
            var linesView = lines.Select(x => new LineTubeViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            //Add serviceType to line
            foreach (var item in lines)
            {
                foreach (var c in item.ServiceTypes)
                {
                    linesView.Single(x => x.Id == item.Id).ServiceType += c.Name + " ";
                }
            }
            return linesView;
        }

        public List<StationTubeViewModel> GetLine(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/" + id + "/stoppoints");
            if (stringJson == null)
                return null;
            var st = JsonConvert.DeserializeObject<List<StopPoint>>(stringJson);
            var stations = JsonConvert.DeserializeObject<List<StopPoint>>(stringJson).Select(
                x => new StationTubeViewModel
                {
                    Id = x.Id,
                    Name = x.CommonName,
                    Lat = x.Lat,
                    Lon = x.Lon
                }).ToList();

            return stations;
        }

        public List<LineBusViewModel> GetLineBus()
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/bus/status");
            if (stringJson == null)
                return null;
            var lines = JsonConvert.DeserializeObject<List<Line>>(stringJson);
            var linesView = lines.OrderBy(x => x.Id).Select(x => new LineBusViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
          

            return linesView;
        }

        public string GetLineInfo(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/"+id+"/route");
            if (stringJson == null)
                return null;
            var line = JsonConvert.DeserializeObject<Line>(stringJson);
           
            int i = 0;
            string result = "";
            foreach(var item in line.RouteSections)
            {
                result += "<label>"+item.Name+ "</label>";
                i++;
            }

            return result;

        }

        public List<StopViewModel> GetStops(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/" + id + "/stoppoints");
            if (stringJson == null)
                return null;
            var stops = JsonConvert.DeserializeObject<List<StopPoint>>(stringJson).Select(x=> new StopViewModel { 
                Id=x.Id,
                Name=x.CommonName,
                Lat=x.Lat,
                Lon=x.Lon
            }).ToList();

            return stops;
        }

        public List<LineStopViewModel> GetPrediction(string id)
        {   
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/StopPoint/" + id+"/Arrivals");
            if (stringJson == null)
                return null;
            var stops = JsonConvert.DeserializeObject<List<Prediction>>(stringJson).OrderBy(x=>x.ExpectedArrival).Select(x=>new LineStopViewModel {
                Id=x.Id,
                NameLine=x.LineName,
                Destination=x.DestinationName,
                TimeArrive=x.ExpectedArrival.ToShortTimeString()
            }).ToList();


            return stops;
        }

       public string GetRoutes(string id)
        {
            string result="";
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/StopPoint/" + id);
            if (stringJson == null)
                return null;
            var stop = JsonConvert.DeserializeObject<StopPoint>(stringJson);

            foreach(var item in stop.Lines)
            {
                result += item.Name+",  ";
            }
            return result;
        }

        public void test(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/StopPoint/" + id);


            var stops = JsonConvert.DeserializeObject<List<Prediction>>(stringJson).OrderBy(x => x.ExpectedArrival);
        }
    }
}

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

        //Get a list of tube lines
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

        //Get a list of stop point lines tube
        public List<StationTubeViewModel> GetLine(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/" + id + "/stoppoints");
            if (stringJson == null)
                return null;          
            return JsonConvert.DeserializeObject<List<StopPoint>>(stringJson).Select(
                 x => new StationTubeViewModel
                 {
                     Id = x.Id,
                     Name = x.CommonName,
                     Lat = x.Lat,
                     Lon = x.Lon
                 }).ToList();
        }

        //Get a list of bus lines
        public List<LineBusViewModel> GetLineBus()
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/bus/status");
            if (stringJson == null)
                return null;
            var lines = JsonConvert.DeserializeObject<List<Line>>(stringJson);
            return lines.OrderBy(x => x.Id).Select(x => new LineBusViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        //Get string information about a line
        public string GetLineInfo(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/" + id + "/route");
            if (stringJson == null)
                return null;
            var line = JsonConvert.DeserializeObject<Line>(stringJson);

            int i = 0;
            string result = "";
            foreach (var item in line.RouteSections)
            {
                result += "<label>" + item.Name + "</label>";
                i++;
            }

            return result;
        }

        //Get list of stop point  a line bus
        public List<StopViewModel> GetStops(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/" + id + "/stoppoints");
            if (stringJson == null)
                return null;
            var stops = JsonConvert.DeserializeObject<List<StopPoint>>(stringJson).Select(x => new StopViewModel
            {
                Id = x.Id,
                Name = x.CommonName,
                Lat = x.Lat,
                Lon = x.Lon
            }).ToList();

            return stops;
        }

        //Get list of predictions  stop point
        public List<LineStopViewModel> GetPrediction(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/StopPoint/" + id + "/Arrivals");
            if (stringJson == null)
                return null;
            var stops = JsonConvert.DeserializeObject<List<Prediction>>(stringJson).OrderBy(x => x.ExpectedArrival).Select(x => new LineStopViewModel
            {
                Id = x.Id,
                NameLine = x.LineName,
                Destination = x.DestinationName,
                TimeArrive = x.ExpectedArrival.ToShortTimeString()
            }).ToList();

            return stops;
        }

        //Get list of line informations
        public List<LineBusViewModel> GetRoutes(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/StopPoint/" + id + "/Route");
            if (stringJson == null)
                return null;
            var stop = JsonConvert.DeserializeObject<List<StopPointRouteSection>>(stringJson).Select(x => new LineBusViewModel
            {
                Id = x.LineId,
                Name = x.RouteSectionName,
                ServiceType = x.ServiceType
            }).ToList();

            return stop;
        }

        //Search  stops point
        public List<StopViewModel> SearchStop(string name)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/StopPoint/Search/" + name, "modes=bus&");
            if (stringJson == null)
                return null;
            var response = JsonConvert.DeserializeObject<SearchResponse>(stringJson);

            var stops = new List<StopViewModel>();
            foreach (var item in response.Matches)
            {
                stops.Add(new StopViewModel
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }

            return stops;
        }       
    }
}

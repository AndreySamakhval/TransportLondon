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
    public class TflService
    {
        TflApiProvider _provider = new TflApiProvider();

        public void GetAllRoad()
        {
           string stringJson = _provider.GetJson("https://api.tfl.gov.uk/road");
            List<RoadCorridor> roads = JsonConvert.DeserializeObject<List<RoadCorridor>>(stringJson);
        }

        public void GetLineTube()
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/tube/status");
            List<Line> lines = JsonConvert.DeserializeObject<List<Line>>(stringJson);
        }

        public void GetLineBus()
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/bus/status");
            List<Line> lines = JsonConvert.DeserializeObject<List<Line>>(stringJson);
        }

        public List<LineViewModel> GetLine(string mode)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/"+mode+"/status");
            
            return JsonConvert.DeserializeObject<List<Line>>(stringJson).Select(x => new LineViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ModeName = x.ModeName
               // RouteSection = x.RouteSections.Select(c=>string.Format(c.DestinationName))
            }).ToList();
        }
    }
}

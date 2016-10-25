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

        //public void GetAllRoad()
        //{
        //   string stringJson = _provider.GetJson("https://api.tfl.gov.uk/road");
        //    List<RoadCorridor> roads = JsonConvert.DeserializeObject<List<RoadCorridor>>(stringJson);
        //}
        ///////////////////////
        public List<LineTubeViewModel> GetLineTube()
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/tube/status");
            var lines = JsonConvert.DeserializeObject<List<Line>>(stringJson);
            var linesView = lines.Select(x => new LineTubeViewModel
            {
                Id = x.Id,
                Name = x.Name             
            }).ToList();

            //Add serviceType to line
            foreach(var item in lines)
            {
                foreach(var c in item.ServiceTypes)
                {
                    linesView.Single(x => x.Id == item.Id).ServiceType += c.Name + " ";
                }
            }
            return linesView;
        }



        public List<StationTubeViewModel> GetLine(string id)
        {
            string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/"+id+"/stoppoints");
            var st = JsonConvert.DeserializeObject<List<StopPoint>>(stringJson);
            var stations = JsonConvert.DeserializeObject<List<StopPoint>>(stringJson).Select(
                x=>new StationTubeViewModel {
                    Id=x.Id,
                    Name=x.CommonName,
                    Lat=x.Lat,
                    Lon=x.Lon
            }).ToList();

            return stations;
        }


        //public void GetLineBus()
        //{
        //    string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/bus/status");
        //    List<Line> lines = JsonConvert.DeserializeObject<List<Line>>(stringJson);
        //}

        //    public List<LineTubeViewModel> GetLine(string mode)
        //    {
        //        string stringJson = _provider.GetJson("https://api.tfl.gov.uk/line/mode/"+mode+"/status");
        //        var lines = JsonConvert.DeserializeObject<List<Line>>(stringJson); 
        //        var linesView = lines.Select(x => new LineTubeViewModel
        //        {
        //            Id = x.Id,
        //            Name = x.Name

        //            //  RouteSection = x.RouteSections.Select(r=>r.Name).ToArray()
        //        }).ToList();


        //        return linesView;
        //    }
    }
}

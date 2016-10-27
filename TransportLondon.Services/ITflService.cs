using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLondon.Viewmodel;

namespace TransportLondon.Services
{
    public interface ITflService
    {
        List<LineTubeViewModel> GetLineTube();
        List<StationTubeViewModel> GetLine(string id);
        List<LineBusViewModel> GetLineBus();
        string GetLineInfo(string id);
        List<StopViewModel> GetStops(string id);
        List<LineStopViewModel> GetPrediction(string id);
        string GetRoutes(string id);
        void test(string id);////////////////////////////////////////
    }
}

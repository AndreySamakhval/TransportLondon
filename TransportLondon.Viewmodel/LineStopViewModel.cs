using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLondon.Viewmodel
{
    public class LineStopViewModel
    {
        public string Id { get; set; }
        public string NameLine { get; set; }
        public string Destination { get; set; }
        public string TimeArrive { get; set; }
    }
}

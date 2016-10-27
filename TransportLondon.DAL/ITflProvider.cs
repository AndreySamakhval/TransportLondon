using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLondon.DAL
{
     public interface ITflProvider
    {
        string GetJson(string url, string parameters = "");
    }
}

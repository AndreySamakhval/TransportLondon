// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Prediction
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;
using System.Web;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class Prediction : IIdentifiable
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public int OperationType { get; set; }

    [DataMember]
    public string VehicleId { get; set; }

    [DataMember]
    public string NaptanId { get; set; }

    [DataMember]
    public string StationName { get; set; }

    [DataMember]
    public string LineId { get; set; }

    [DataMember]
    public string LineName { get; set; }

    [DataMember]
    public string PlatformName { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public string Bearing { get; set; }

    public string VisitNumber { get; set; }

    public string TripId { get; set; }

    public string VehicleCDId { get; set; }

    [DataMember]
    public string DestinationNaptanId { get; set; }

    [DataMember]
    public string DestinationName { get; set; }

    [DataMember]
    public DateTime Timestamp { get; set; }

    [DataMember]
    public int? TimeToStation { get; set; }

    [DataMember]
    public string CurrentLocation { get; set; }

    [DataMember]
    public string Towards { get; set; }

    [DataMember]
    public DateTime ExpectedArrival { get; set; }

    [DataMember]
    public DateTime TimeToLive { get; set; }

    [DataMember]
    public string ModeName { get; set; }

    public DateTime ServerTimestamp { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.NaptanId,
        Name = string.Format("{0} - {1}", (object) this.StationName, (object) this.LineName),
        Type = typeof (Prediction).Name,
        Uri = string.Format("/Line/{1}/Arrivals/{0}", (object) HttpUtility.UrlEncode(this.NaptanId), (object) HttpUtility.UrlEncode(this.LineId))
      };
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.MatchedRoute
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Name = "MatchedRoute")]
  public class MatchedRoute : IIdentifiable
  {
    public string Id { get; set; }

    public string LineId { get; set; }

    [DataMember]
    public string RouteCode { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public string OriginationName { get; set; }

    [DataMember]
    public string DestinationName { get; set; }

    [DataMember]
    public string Originator { get; set; }

    [DataMember]
    public string Destination { get; set; }

    [DataMember]
    public string ServiceType { get; set; }

    public MatchedRoute()
    {
    }

    public MatchedRoute(string id, string lineId, string routeCode, string name, string direction, string lineString, string originationName, string destinationName, string originator, string destination, string serviceType)
    {
      this.Id = id;
      this.LineId = lineId;
      this.RouteCode = routeCode;
      this.Name = name;
      this.Direction = direction;
      this.OriginationName = originationName;
      this.DestinationName = destinationName;
      this.Originator = originator;
      this.Destination = destination;
      this.ServiceType = serviceType;
    }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id.ToString((IFormatProvider) CultureInfo.InvariantCulture),
        Name = this.Name,
        Type = typeof (MatchedRoute).Name,
        Uri = string.Format("/MatchedRoute/{0}", (object) this.Id)
      };
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.LineRouteSection
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class LineRouteSection
  {
    [DataMember]
    public int RouteId { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public string Destination { get; set; }

    [DataMember]
    public string FromStation { get; set; }

    [DataMember]
    public string ToStation { get; set; }

    [DataMember]
    public string ServiceType { get; set; }

    [DataMember]
    public string VehicleDestinationText { get; set; }
  }
}

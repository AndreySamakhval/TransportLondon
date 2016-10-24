// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.StopPointRouteSection
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class StopPointRouteSection
  {
    [DataMember]
    public string NaptanId { get; set; }

    [DataMember]
    public string LineId { get; set; }

    [DataMember]
    public string Mode { get; set; }

    [DataMember]
    public DateTime ValidFrom { get; set; }

    [DataMember]
    public DateTime ValidTo { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public string RouteSectionName { get; set; }

    [DataMember]
    public string LineString { get; set; }

    [DataMember]
    public bool IsActive { get; set; }

    [DataMember]
    public string ServiceType { get; set; }

    [DataMember]
    public string VehicleDestinationText { get; set; }

    [DataMember]
    public string DestinationName { get; set; }
  }
}

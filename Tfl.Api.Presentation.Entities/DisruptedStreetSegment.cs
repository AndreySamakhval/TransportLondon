// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.DisruptedStreetSegment
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class DisruptedStreetSegment
  {
    [DataMember]
    public string StreetName { get; set; }

    [DataMember]
    public string Closure { get; set; }

    [DataMember]
    public string Directions { get; set; }

    [DataMember]
    public string LineString { get; set; }

    [DataMember]
    public string DistruptedStreetId { get; set; }

    [DataMember]
    public string DisruptionId { get; set; }

    [DataMember]
    public double StartLat { get; set; }

    [DataMember]
    public double StartLon { get; set; }

    [DataMember]
    public double EndLat { get; set; }

    [DataMember]
    public double EndLon { get; set; }

    [DataMember]
    public string Severity { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Category { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string SubCategory { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Comments { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? StartDateTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? EndDateTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string LevelOfInterest { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Location { get; set; }
  }
}

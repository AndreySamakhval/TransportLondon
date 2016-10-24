// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.RoadDisruptionLine
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using Newtonsoft.Json;
using System;
using System.Data.Spatial;
using System.Runtime.Serialization;
//using Tfl.Api.Common;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class RoadDisruptionLine
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string RoadDisruptionId { get; set; }

    [DataMember]
    public bool IsDiversion { get; set; }

    [DataMember(EmitDefaultValue = false)]
  //  [JsonConverter(typeof (DbGeographyGeoJsonConverter))]
    public DbGeography MultiLineString { get; set; }

    [DataMember]
    public DateTime StartDate { get; set; }

    [DataMember]
    public DateTime EndDate { get; set; }

    [DataMember]
    public TimeSpan StartTime { get; set; }

    [DataMember]
    public TimeSpan EndTime { get; set; }
  }
}

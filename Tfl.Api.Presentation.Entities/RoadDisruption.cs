// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.RoadDisruption
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Runtime.Serialization;
using System.Web;
//using Tfl.Api.Common;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class RoadDisruption : IGeoData, IIdentifiable
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Url { get; set; }

    [DataMember]
    public string Point { get; set; }

    [DataMember]
    public string Severity { get; set; }

    [DataMember]
    public int Ordinal { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Category { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string SubCategory { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Comments { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string CurrentUpdate { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? CurrentUpdateDateTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<string> CorridorIds { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? StartDateTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? EndDateTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? LastModifiedTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string LevelOfInterest { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Location { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Status { get; set; }

    [DataMember(EmitDefaultValue = false)]
 //   [JsonConverter(typeof (DbGeographyGeoJsonConverter))]
    public DbGeography Geography { get; set; }

   // [JsonConverter(typeof (DbGeographyGeoJsonConverter))]
    [DataMember(EmitDefaultValue = false)]
    public DbGeography Geometry { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<Street> Streets { get; set; }

    [DataMember]
    public bool IsProvisional { get; set; }

    [DataMember]
    public bool HasClosures { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string LinkText { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string LinkUrl { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public RoadProject RoadProject { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime PublishStartDate { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime PublishEndDate { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string TimeFrame { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<RoadDisruptionLine> RoadDisruptionLines { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<RoadDisruptionImpactArea> RoadDisruptionImpactAreas { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Name = this.RoadProject == null ? string.Format("RoadDisruption #{0}", (object) this.Id) : this.RoadProject.ProjectName,
        Type = typeof (RoadDisruption).Name,
        Uri = string.Format("/Road/All/Disruption/{0}", (object) HttpUtility.UrlEncode(this.Id))
      };
    }
  }
}

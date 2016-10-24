// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.RoadCorridor
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;
using System.Web;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class RoadCorridor : IIdentifiable
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string DisplayName { get; set; }

    [DataMember]
    public string Group { get; set; }

    [DataMember]
    public string StatusSeverity { get; set; }

    [DataMember]
    public string StatusSeverityDescription { get; set; }

    [DataMember]
    public string Bounds { get; set; }

    [DataMember]
    public string Envelope { get; set; }

    [DataMember]
    public DateTime? StatusAggregationStartDate { get; set; }

    [DataMember]
    public DateTime? StatusAggregationEndDate { get; set; }

    [DataMember]
    public string Url { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Type = typeof (RoadCorridor).Name,
        Uri = string.Format("/Road/{0}", (object) HttpUtility.UrlEncode(this.Id))
      };
    }
  }
}

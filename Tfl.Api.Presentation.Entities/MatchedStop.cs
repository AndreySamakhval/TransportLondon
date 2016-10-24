// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.MatchedStop
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class MatchedStop : SearchMatch, IIdentifiable, IComparable<MatchedStop>
  {
    [DataMember(EmitDefaultValue = false)]
    public int RouteId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string ParentId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string StationId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string IcsId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string TopMostParentId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Direction { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Towards { get; set; }

    [DataMember(Name = "Modes")]
    public ModeList Modes { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string StopType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string StopLetter { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Zone { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string AccessibilitySummary { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool HasDisruption { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<Identifier> Lines { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool Status { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Name = this.Name,
        Type = typeof (StopPoint).Name,
        Uri = "/StopPoint/" + this.Id
      };
    }

    public int CompareTo(MatchedStop obj)
    {
      if (obj == null)
        return -1;
      return string.Compare(this.Name, obj.Name, StringComparison.Ordinal);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.StopPoint
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class StopPoint : Place, IIdentifiable, IComparable<StopPoint>
  {
    [DataMember(EmitDefaultValue = false)]
    public string NaptanId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string PlatformName { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Indicator { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string StopLetter { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public ModeList Modes { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string IcsCode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string SMSCode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string StopType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string StationNaptan { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string AccessibilitySummary { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string HubNaptanCode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<Identifier> Lines { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<Tfl.Api.Presentation.Entities.LineGroup> LineGroup { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<LineModeGroup> LineModeGroups { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string FullName { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string NaptanMode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool Status { get; set; }

    public new Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.NaptanId,
        Name = this.CommonName,
        Type = typeof (StopPoint).Name,
        Uri = string.Format("/StopPoint/{0}", (object) this.NaptanId),
        FullName = this.FullName
      };
    }

    public int CompareTo(StopPoint obj)
    {
      if (obj == null)
        return -1;
      return string.Compare(this.CommonName, obj.CommonName, StringComparison.Ordinal);
    }
  }
}

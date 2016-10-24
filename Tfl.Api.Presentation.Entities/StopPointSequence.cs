// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.StopPointSequence
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  public class StopPointSequence : IIdentifiable
  {
    [DataMember]
    public string LineId { get; set; }

    [DataMember]
    public string LineName { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public int BranchId { get; set; }

    [DataMember]
    public ICollection<int> NextBranchIds { get; set; }

    [DataMember]
    public ICollection<int> PrevBranchIds { get; set; }

    [DataMember]
    public ICollection<MatchedStop> StopPoint { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.LineId,
        Type = typeof (StopPointSequence).Name,
        Uri = string.Format("/Line/{0}/Route/Sequence/{1}", (object) this.LineId, (object) this.Direction)
      };
    }
  }
}

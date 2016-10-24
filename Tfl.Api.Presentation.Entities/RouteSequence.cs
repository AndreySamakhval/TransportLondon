// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.RouteSequence
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Name = "RouteSequence")]
  public class RouteSequence : IIdentifiable
  {
    [DataMember]
    public string LineId { get; set; }

    [DataMember]
    public string LineName { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public bool IsOutboundOnly { get; set; }

    [DataMember]
    public string Mode { get; set; }

    [DataMember]
    public List<string> LineStrings { get; set; }

    [DataMember]
    public List<MatchedStop> Stations { get; set; }

    [DataMember]
    public List<StopPointSequence> StopPointSequences { get; set; }

    [DataMember]
    public List<OrderedRoute> OrderedLineRoutes { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.LineId,
        Type = typeof (RouteSequence).Name,
        Uri = string.Format("/Line/{0}/Route/Sequence/{1}", (object) this.LineId, (object) this.Direction)
      };
    }
  }
}

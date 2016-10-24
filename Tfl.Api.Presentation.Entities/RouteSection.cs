// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.RouteSection
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Name = "RouteSection")]
  public class RouteSection : IIdentifiable
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string LineId { get; set; }

    [DataMember]
    public string RouteCode { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public string LineString { get; set; }

    [DataMember]
    public string OriginationName { get; set; }

    [DataMember]
    public string DestinationName { get; set; }

    [DataMember]
    public IEnumerable<Tfl.Api.Presentation.Entities.RouteSectionNaptanEntrySequence> RouteSectionNaptanEntrySequence { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id.ToString((IFormatProvider) CultureInfo.InvariantCulture),
        Name = this.Name,
        Type = typeof (RouteSection).Name
      };
    }
  }
}

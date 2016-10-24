// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Line
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Name = "Line")]
  public class Line : IIdentifiable
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string ModeName { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public ICollection<Disruption> Disruptions { get; set; }

    [DataMember]
    public DateTime Created { get; set; }

    [DataMember]
    public DateTime? Modified { get; set; }

    [DataMember(Name = "LineStatuses")]
    public ICollection<Tfl.Api.Presentation.Entities.LineStatus> LineStatus { get; set; }

    [DataMember]
    public ICollection<MatchedRoute> RouteSections { get; set; }

    [DataMember]
    public ICollection<LineServiceTypeInfo> ServiceTypes { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Name = this.Name,
        Type = typeof (Line).Name,
        Uri = string.Format("/Line/{0}", (object) this.Id)
      };
    }
  }
}

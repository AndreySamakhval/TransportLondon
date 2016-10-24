// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.PlannedWorks
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class PlannedWorks : IIdentifiable
  {
    public string Id { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime Created { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime LastUpdate { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public IEnumerable<ValidityPeriod> ValidityDates { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public IEnumerable<Identifier> AffectedRoutes { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public IEnumerable<StopPoint> AffectedStops { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public IEnumerable<Identifier> AffectedModes { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool IsBlocking { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool IsWholeLine { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Name = this.Description,
        Type = typeof (PlannedWorks).Name
      };
    }
  }
}

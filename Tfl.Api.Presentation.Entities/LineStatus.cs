// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.LineStatus
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Name = "LineStatus")]
  public class LineStatus : IIdentifiable
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string LineId { get; set; }

    [DataMember]
    public int? StatusSeverity { get; set; }

    [DataMember]
    public string StatusSeverityDescription { get; set; }

    [DataMember]
    public string Reason { get; set; }

    [DataMember]
    public DateTime Created { get; set; }

    [DataMember]
    public DateTime? Modified { get; set; }

    [DataMember(Name = "ValidityPeriods")]
    public ICollection<Tfl.Api.Presentation.Entities.ValidityPeriod> ValidityPeriod { get; set; }

    [DataMember]
    public Disruption Disruption { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id.ToString((IFormatProvider) CultureInfo.InvariantCulture),
        Name = string.Format("{0} - {1}", (object) this.StatusSeverity, (object) this.StatusSeverityDescription),
        Type = typeof (LineStatus).Name,
        Uri = string.Format("/Line/{0}/Status", (object) this.Id)
      };
    }
  }
}

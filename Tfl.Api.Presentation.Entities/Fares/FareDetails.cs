// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.FareDetails
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Fares
{
  [DataContract]
  public class FareDetails
  {
    [DataMember(EmitDefaultValue = false)]
    public int BoundsId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime StartDate { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime EndDate { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Mode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string PassengerType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string From { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string To { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string FromStation { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string ToStation { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Via { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string RouteCode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember]
    public int DisplayOrder { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string RouteDescription { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string ValidatorInformation { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Operator { get; set; }

    [DataMember]
    public bool SpecialFare { get; set; }

    [DataMember]
    public bool ThroughFare { get; set; }

    [DataMember]
    public bool IsTour { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public ICollection<Ticket> TicketsAvailable { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public ICollection<Message> Messages { get; set; }
  }
}

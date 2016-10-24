// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.Fare
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Fares
{
  [DataContract]
  public class Fare
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string PassengerType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime ValidFrom { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime ValidUntil { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string TicketTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string TicketType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Cost { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public Decimal? Cap { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Zone { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Mode { get; set; }
  }
}

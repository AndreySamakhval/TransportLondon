// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.Ticket
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Fares
{
  [DataContract]
  public class Ticket
  {
    [DataMember(EmitDefaultValue = false)]
    public string PassengerType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public TicketType TicketType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public TicketTime TicketTime { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Cost { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Mode { get; set; }

    [DataMember]
    public int DisplayOrder { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public ICollection<Message> Messages { get; set; }
  }
}

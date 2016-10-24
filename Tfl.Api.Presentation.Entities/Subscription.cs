// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Subscription
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class Subscription : IIdentifiable
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string ConnectionId { get; set; }

    [DataMember]
    public string RoomName { get; set; }

    [DataMember]
    public string NaptanId { get; set; }

    [DataMember]
    public string LineId { get; set; }

    public string Source { get; set; }

    [DataMember]
    public DateTime Timestamp { get; set; }

    [DataMember]
    public DateTime TimeToLive { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Name = string.Format("{0} - {1}", (object) this.ConnectionId, (object) this.RoomName),
        Type = typeof (Subscription).Name,
        Uri = string.Empty
      };
    }
  }
}

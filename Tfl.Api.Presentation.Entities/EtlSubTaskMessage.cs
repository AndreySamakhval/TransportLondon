// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.EtlSubTaskMessage
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class EtlSubTaskMessage
  {
    [DataMember]
    public long OperationMessageId { get; set; }

    [DataMember]
    public string PackagePath { get; set; }

    [DataMember]
    public string Message { get; set; }

    [DataMember]
    public DateTimeOffset MessageTime { get; set; }

    [DataMember]
    public string MessageType { get; set; }

    [DataMember]
    public string MessageSourceType { get; set; }
  }
}

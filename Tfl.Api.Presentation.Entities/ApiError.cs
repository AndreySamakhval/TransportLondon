// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.ApiError
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  [Serializable]
  public class ApiError
  {
    [DataMember]
    public DateTime TimestampUtc { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string ExceptionType { get; set; }

    [DataMember]
    public int HttpStatusCode { get; set; }

    [DataMember]
    public System.Net.HttpStatusCode HttpStatus { get; set; }

    [DataMember]
    public string RelativeUri { get; set; }

    [DataMember]
    public string Message { get; set; }

    [DataMember]
    public string DetailedMessage { get; set; }
  }
}

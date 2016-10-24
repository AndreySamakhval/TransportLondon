// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.ServiceInfo
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Name = "ServiceInfo")]
  public class ServiceInfo
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Operator { get; set; }

    [DataMember]
    public string Supplement { get; set; }

    [DataMember]
    public DateTime ValidFrom { get; set; }

    [DataMember]
    public DateTime ValidTo { get; set; }

    [DataMember]
    public string ICSCode { get; set; }

    [DataMember]
    public List<RouteInfo> RouteSections { get; set; }
  }
}

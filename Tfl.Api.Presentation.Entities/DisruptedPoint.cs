﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.DisruptedPoint
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class DisruptedPoint
  {
    [DataMember]
    public string AtcoCode { get; set; }

    [DataMember]
    public DateTime? FromDate { get; set; }

    [DataMember]
    public DateTime? ToDate { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public string CommonName { get; set; }

    [DataMember]
    public string Type { get; set; }

    [DataMember]
    public string Mode { get; set; }

    [DataMember]
    public string StationAtcoCode { get; set; }

    [DataMember]
    public string Appearance { get; set; }

    [DataMember]
    public string AdditionalInformation { get; set; }
  }
}
